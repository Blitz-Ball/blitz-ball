using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    public GameObject hitSFX;

    private Rigidbody2D rb;
    public BallMovement ballMovement;
    public Score_Manager scoreManager;
    public float Maxball=15;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    public void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if(collision.gameObject.name == "Player 1")
        {
            positionX = 1;
        }

        else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }

       else if(collision.gameObject.name == "Goal R")
        {
            scoreManager.Player1Goal();
            ballMovement.player1Start = false;
            StartCoroutine(ballMovement.Launch());
        }

        else if (collision.gameObject.name == "Goal L")
        {
            scoreManager.Player2Goal();
            ballMovement.player1Start = true;
            StartCoroutine(ballMovement.Launch());
        }

        Instantiate(hitSFX, transform.position, transform.rotation);
    }
    void Update()
    {
        if(rb.velocity.sqrMagnitude>Maxball)
        {
            Vector2 vec=rb.velocity.normalized;
            rb.velocity=vec*Maxball;
        }
    }
}
