using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Transform target;
    Vector2 newposition;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        newposition=transform.position;
        newposition.y=Mathf.Clamp(newposition.y,-2,2);
        newposition.x=Mathf.Clamp(newposition.x,7.5f,10f);
        transform.position=newposition;
        
        
        
        /*if (rb.transform.position.x < 6.5f)
        {
            rb.transform.position = new Vector2(6.51f, rb.transform.position.y);
        }
        if (rb.transform.position.y <- 2f)
        {
            rb.transform.position = new Vector2(rb.transform.position.x,-1.99f);
        }
        if (rb.transform.position.y > 2f)
        {
            rb.transform.position = new Vector2(rb.transform.position.x,1.99);
        }*/
    }
}
