using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEvil : MonoBehaviour
{

    public float speed = 30f;
    float timer, timer2, timerDeath, timerD;
    bool pulsar;
    bool dale;


     Vector3 instantaiatePoint;
    public GameObject player;
     int pull = 0;

    //Trigo
    float vectorXXWood, vectorXYWood, vectorXZWood, vectorXXCamera, vectorXYCamera, vectorXZCamera, arcTangente, angA, catetoX, catetoY, catetoZ;


    void Update()
    {
        timerD += Time.deltaTime;
        if(timerD >= 0.7f)
        {
            Destroy(gameObject);
        }
            
            if(pull == 0)
            {
                player = GameObject.Find("Player------------------------------------");
                //Debug.Log(player.gameObject.transform.position.x);
                dale = true;
                pull++;

            vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
            vectorXYCamera = gameObject.GetComponent<Transform>().position.y;
            vectorXZCamera = gameObject.GetComponent<Transform>().position.z;

            vectorXXWood = player.gameObject.transform.position.x;
            vectorXYWood = player.gameObject.transform.position.y;
            vectorXZWood = player.gameObject.transform.position.z;

            catetoX = vectorXXCamera - vectorXXWood;
            catetoY = vectorXYCamera - vectorXYWood;
            catetoZ = vectorXZCamera - vectorXZWood;

            instantaiatePoint = new Vector3(vectorXXWood - catetoX, (vectorXYWood + 0.5f) - catetoY, vectorXZWood - catetoZ);


            if (catetoX < 0)
            {
                catetoX *= -1;
            }
            if (catetoZ < 0)
            {
                catetoZ *= -1;
            }

            arcTangente = (Mathf.Atan(catetoZ / catetoX));
            
            arcTangente = (arcTangente * 180) / Mathf.PI;
            
            angA = arcTangente;

            if (angA < 0)
            {
                angA *= -1;
            }

            angA = 90 - angA;

            if (vectorXXCamera > vectorXXWood)
            {
                if(vectorXZCamera < vectorXZWood)
                {
                    angA = angA * (-1);

                }
            }
            if (vectorXXCamera < vectorXXWood)
            {
                if (vectorXZCamera > vectorXZWood)
                {
                    angA = (angA * -1) + 180;
                }
            }
            if (vectorXXCamera > vectorXXWood)
            {
                if (vectorXZCamera > vectorXZWood)
                {
                    angA = (angA) - 180;
                }
            }
            gameObject.transform.eulerAngles = new Vector3(0, angA, 0);

            }
            

            if(dale)
            {
                float step =  speed * Time.deltaTime;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, instantaiatePoint, step);
                gameObject.transform.eulerAngles = new Vector3(0, angA, 0);
            }
        
    }


    private void OnTriggerEnter(Collider collider) 
    {
        if(collider.transform.tag == "ground")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "player1")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collider) 
    {
        if(collider.transform.tag == "ground")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "wall")
        {
            Destroy(gameObject);
        }
        if(collider.transform.tag == "blockY")
        {
            Destroy(gameObject); 
        }
    }
}
