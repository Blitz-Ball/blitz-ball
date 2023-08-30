using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float RacketSpeed;


    private Rigidbody2D rb;
    private Vector2 racketDirection;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    public void RestartPlayer()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(7.5f, -0.345f);
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");
        float directionX = Input.GetAxisRaw("Horizontal2");

        racketDirection = new Vector2(directionX, directionY).normalized;
        rb.velocity = new Vector2(directionX * RacketSpeed, directionY * RacketSpeed);

        if (rb.transform.position.x <= 0)
        {
            rb.transform.position = new Vector2(0, rb.transform.position.y);
        }

    }

}
