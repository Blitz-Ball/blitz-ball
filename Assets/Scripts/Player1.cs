using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float RacketSpeed;

    private Rigidbody2D rb;
    private Vector2 racketDirection;
    Vector2 newposition;

    // Start is called before the first frame update
    void Start()
    {
    
        rb = GetComponent<Rigidbody2D>();
        
    }

    public void RestartPlayer()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(-4f, -0.345f);
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
     
        racketDirection = new Vector2(directionX, directionY).normalized;
     
        rb.velocity = new Vector2(directionX * RacketSpeed, directionY * RacketSpeed);
        
        
        newposition=transform.position;
        newposition.y=Mathf.Clamp(newposition.y,-4.2f,3.565f);
        newposition.x=Mathf.Clamp(newposition.x,-8f,-0.8f);
        transform.position=newposition;

     
      
     
     
    }

   
}
