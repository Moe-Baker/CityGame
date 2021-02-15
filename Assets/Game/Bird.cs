using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rg;
    public float speed;

    int angle;
    int maxAngle = 20;
    int minAngle = -90;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rg.velocity = Vector2.zero;
            rg.velocity = new Vector2(rg.velocity.x, speed);
        }


        //Bird Rotation
        if(rg.velocity.y > 0)
        {
            if(angle <= maxAngle)
            {
                angle = angle + 3;
            }
        }
        else if(rg.velocity.y < -1.2f)
        {
            if(angle >= minAngle)
            {
                angle = angle - 3;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
       
    }
}
