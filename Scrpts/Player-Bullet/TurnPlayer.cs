using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

        float timer, timer1;
        int rotate = 0, rotate1 = 0;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            timer += Time.deltaTime;
            if(Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
            {
                if(rotate > -80)
                {
                    //Debug.Log(" 0 " + rotate);
                    if(timer>=0.01)
                    {
                        rotate-=10;
                        timer=0;
                    } 
                }
                transform.RotateAround(transform.position, Vector3.up, rotate);
            }
            else
            {
                transform.RotateAround(transform.position, Vector3.up, -45);
            }
        }
        else
        {
            if(rotate<=0)
            {
                timer += Time.deltaTime;
                if(timer>=0.01)
                {
                    rotate += 10;
                    timer=0;
                } 
                transform.RotateAround(transform.position, Vector3.up, rotate);
            }
        }


    if(Input.GetKey("d"))
        {
            timer1 += Time.deltaTime;
            if(Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
                {
                    if(rotate1 <91)
                    {
                        if(timer1>=0.1)
                        {
                            rotate1+=10;
                            timer1=0;
                        } 
                    }
                    transform.RotateAround(transform.position, Vector3.up, rotate1);
                }
                else
                {
                    transform.RotateAround(transform.position, Vector3.up, 45);
                }
        }
        else
        {
            if(rotate1>=0)
            {
                timer1 += Time.deltaTime;
                if(timer1 >= 0.1)
                {
                    rotate1-=10;
                
                    timer1 = 0;
                } 
                transform.RotateAround(transform.position, Vector3.up, rotate1);
            }
        }










           
    }
}
