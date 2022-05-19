using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTramp1 : MonoBehaviour
{

    float speed = 30.0f;
    float timerD;
    bool dale;

    Vector3 instantaiatePoint;
    int pull;

    float yScale, timeDestroy;

    void Start()
    {
        timeDestroy = 0.5f;
        yScale = 0.03f;
        pull = 0;

    }
    void Update()
    {
        
        timerD += Time.deltaTime;
        if(timerD >= timeDestroy)
        {
            Destroy(gameObject);
        }
            
        if(pull == 0)
        {
            dale = true;
            pull = 1;
            
            instantaiatePoint = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 20);

        }



        if(dale)
        {
            float step =  speed * Time.deltaTime;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, instantaiatePoint, step);
        }           
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if(collider.transform.tag == "ground")
        {
            //Destroy(gameObject);
        }
        if(collider.transform.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "evil")
        {
            Destroy(gameObject);
        }
        if (collider.transform.tag == "groundStair")
        {
            Destroy(gameObject);
//            Debug.Log("Escalon  ");
        }
    }

    private void OnCollisionEnter(Collision collider) 
    {
        if(collider.transform.tag == "ground")
        {
            Destroy(gameObject);
            //Debug.Log("EvilTouched");
        }
        if(collider.transform.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "wallR")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "wallL")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "evil")
        {
            Destroy(gameObject);
        }
        if (collider.transform.tag == "groundStair")
        {
            Destroy(gameObject);
            Debug.Log("Escalon  ");
        }
    }
}
