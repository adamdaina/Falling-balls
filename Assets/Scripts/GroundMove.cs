using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public Transform pointToGo_1;
    public Transform pointToGo_2;
    public GameObject border_2;
    public float speed;
    public bool colliding = false;
    protected int sk = 0;
    

    private void LateUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < 1; i++)
            {
                sk++;
                if (!colliding && (sk % 2 != 0))
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector2.MoveTowards(transform.position, pointToGo_1.position, step);
                   
                }

                if (!colliding && (sk % 2 == 0))
                {
                    float step = speed * Time.deltaTime;
                    border_2.transform.position = Vector2.MoveTowards(border_2.transform.position, pointToGo_2.position, step);
                   
                }
                
            }  
        }
        
        /*if (Input.GetMouseButton(0))
        {
                if (!colliding)
                {
                    float step = speed * Time.deltaTime;
                    border_2.transform.position = Vector2.MoveTowards(border_2.transform.position, pointToGo_2.position, step);
                }
                sk = 0;
        }*/
    }
    //Callback when enter the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = true;
    }

}