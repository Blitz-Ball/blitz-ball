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
        newposition.y=Mathf.Clamp(newposition.y,-2.345f,1.665f);
        newposition.x=Mathf.Clamp(newposition.x,6.5f,8f);
        transform.position=newposition;
        
    }
}
