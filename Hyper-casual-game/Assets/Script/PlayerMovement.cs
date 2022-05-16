using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
 public Vector3 targetPos1;
    
    public Vector3 targetPos2;
   
    public float speed = 1f;
    public bool canMove;
    public bool firstMove;
    public Rigidbody2D rb;
     
     public float sidewayforce = 500f;

    void Start()
    {
        firstMove = true;
    }
    void FixedUpdate()
    {
        if(transform.position == targetPos1)
        {
            firstMove = false;
        }
        if (transform.position == targetPos2)
        {
            firstMove = true;
        }
        if (canMove)
        {
            if (firstMove)
            {
            transform.position = Vector3.MoveTowards(transform.position, targetPos1, speed* Time.deltaTime);

            if(Input.GetKey(KeyCode.RightArrow))
               {
                  rb.AddForce(new Vector2(sidewayforce * Time.deltaTime, 0f));
               }
            if(Input.GetKey(KeyCode.LeftArrow))
               {
                  rb.AddForce(new Vector2(-sidewayforce * Time.deltaTime, 0f));
               }
               }
            else
            {
            transform.position = Vector3.MoveTowards(transform.position, targetPos2, speed* Time.deltaTime);
            if(Input.GetKey(KeyCode.RightArrow))
                {
              rb.AddForce(new Vector2(sidewayforce * Time.deltaTime, 0f));
                }
            if(Input.GetKey(KeyCode.LeftArrow))
                {
              rb.AddForce(new Vector2(-sidewayforce * Time.deltaTime, 0f));
                }
            }
        }   
          
}
}
