using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallMovement : MonoBehaviour
{

    public float startSpeed, extraSpeed, maxExtraSpeed; //we will increase the speed of the ball when it hits the racquet

    public bool player1Start = true;

    public Rigidbody2D ball;
    public Rigidbody2D p1;
    public Rigidbody2D p2;
    public Rigidbody2D p3;
    public Rigidbody2D p4;


    private int hitCounter = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        

        StartCoroutine(Launch());
    }

    private void RestartGame()
    {
        ball.velocity = new Vector2(0, 0);
        ball.transform.position = new Vector2(0, -0.345f);
        p1.transform.position = new Vector2(-7.5f, -0.345f);
        p2.transform.position = new Vector2(7.5f, -0.345f);
        p3.transform.position = new Vector2(-4, -0.345f);
        p4.transform.position = new Vector2(4, -0.345f);

    }

    
    public IEnumerator Launch()
    {
        RestartGame();
        hitCounter = 0;
        yield return new WaitForSeconds(1);

        if(player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }

        else
        {
            MoveBall(new Vector2(1, 0));
        }

    
    }
   
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed = startSpeed + hitCounter * extraSpeed;

        ball.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
}
