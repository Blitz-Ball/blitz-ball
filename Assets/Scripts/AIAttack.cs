using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 startpos;

    public Rigidbody2D puck;
    public Transform Movementrestrict;
    private Boundary AIboundry;

    struct Boundary
    {
        public float Up, Down, Left ,Right;
        public Boundary(float up, float down,float left, float right)
        {
            Up=up;
            Down=down;
            Left=left;
            Right=right;
        }

    }
    private Vector2 Targetposition;

    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        startpos=rb.position;
        AIboundry= new Boundary(6f,-6f,0.8f,6f);
    }

    private void FixedUpdate()
    {
        float movementSpeed;
        if (puck.position.x<0)
        {
            movementSpeed=speed*Random.Range(0.2f,0.3f);
            Targetposition= new Vector2(startpos.x,Mathf.Clamp(puck.position.y,AIboundry.Down,AIboundry.Up));

        }
        else if(puck.position.x>6.5)
        {
            movementSpeed=speed*Random.Range(0.2f,0.3f);
            Targetposition= new Vector2(startpos.x,Mathf.Clamp(puck.position.y,AIboundry.Down,AIboundry.Up));
        }
        else
        {
            movementSpeed = Random.Range(speed*0.5f,speed*1f);
            Targetposition=new Vector2(Mathf.Clamp(puck.position.x,AIboundry.Left,AIboundry.Right),Mathf.Clamp(puck.position.y,AIboundry.Down,AIboundry.Up));
        }
        rb.MovePosition(Vector2.MoveTowards(rb.position,Targetposition,movementSpeed*Time.deltaTime));
    }




}
