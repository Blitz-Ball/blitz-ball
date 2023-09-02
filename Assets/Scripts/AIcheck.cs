using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform puck; // Reference to the puck object
    public float movementSpeed = 5f; // Adjust the AI's movement speed

    private Rigidbody2D rb; // Rigidbody component of the AI striker

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (puck != null)
        {
            // Calculate the direction from the AI striker to the puck
            Vector2 directionToPuck = (Vector2)puck.position - rb.position;

            // Normalize the direction vector
            directionToPuck.Normalize();

            // Move the AI striker towards the puck
            rb.velocity = directionToPuck * movementSpeed;

            // Optionally, you can limit the AI's striker to stay within a certain area
            // ClampPositionToBounds();
        }
        else
        {
            rb.velocity = Vector2.zero; // Stop moving if there is no puck
        }
        ClampPositionToBounds();
    }

    // Optional method to limit the AI's striker to stay within a certain area
    private void ClampPositionToBounds()
    {
        // Define the boundaries of your air hockey table
        float minX = -6.5f;
        float maxX = -10f;
        float miny = -2f;
        float maxy = 2f;

        Vector2 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        currentPosition.y = Mathf.Clamp(currentPosition.y, miny, maxy);
        rb.position = currentPosition;
    }

}