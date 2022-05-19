using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKnife : MonoBehaviour
{
    public AudioSource arrowShoot;

    public float speed = 20.0f;
    float timer, timer2, timerDeath, timerD;
    bool dale;

    Vector3 instantaiatePoint;
    int pull, pull2;

     //TRIGONOMETRIA
     float angA, vectorXXWood, vectorXYWood, vectorXZWood, vectorXXCamera, vectorXYCamera, vectorXZCamera, arcTangente, catetoX, catetoY, catetoZ;

     float yScale, timeDestroy;


    void Start()
    {
        speed = 20.0f;
        for(int i = 0; i < PlayerPrefs.GetInt("potion12ACT"); i++)
        {
            speed -= (speed / 10);
        }

        for(int i = 0; i < PlayerPrefs.GetInt("levelPower04"); i++)
        {
            speed += (speed / 10);
        }
        
        
        if(PlayerPrefs.GetInt("stopArrow") == 0)
        {
            arrowShoot.Play();
        }

        timeDestroy = 0.7f;
        for(int i = 0; i < PlayerPrefs.GetInt("potion13ACT"); i++)
        {
            timeDestroy += (timeDestroy / 10);
        }
        for(int i = 0; i < PlayerPrefs.GetInt("levelPower05"); i++)
        {
            timeDestroy += (timeDestroy / 10);
        }
        yScale = 0.03f;
        pull = 0;

    }
    void Update()
    {
        
        timerD += Time.deltaTime;
        if(timerD >= timeDestroy)
        {
            if(PlayerPrefs.GetInt("potion7ACT") == 0)
            {
                Destroy(gameObject);
            }
        }
            
        if(pull == 0)
        {
            if(pull2 == 0)
            {
                float distanceToClosestEnemy = Mathf.Infinity;
                Enemy closestEnemy = null;
                Enemy[] allEnemies = GameObject.FindObjectsOfType<Enemy>();

                foreach (Enemy currentEnemy in allEnemies) 
                {
                    float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
                    if (distanceToEnemy < distanceToClosestEnemy) 
                    {
                        distanceToClosestEnemy = distanceToEnemy;
                        closestEnemy = currentEnemy;
                        vectorXXWood = closestEnemy.transform.position.x;
                        vectorXYWood = closestEnemy.transform.position.y;
                        vectorXZWood = closestEnemy.transform.position.z;
                    }
                }
                if(PlayerPrefs.GetInt("potion7ACT") == 0)
                {
                    pull2 = 3;
                }
            }
            
            dale = true;
            pull = 1;
            if(PlayerPrefs.GetInt("potion7ACT") == 1)
            {
                pull = 0;    
            }

            vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
            vectorXYCamera = gameObject.GetComponent<Transform>().position.y;
            vectorXZCamera = gameObject.GetComponent<Transform>().position.z;

            /*vectorXXWood = closestEnemy.transform.position.x;
            vectorXYWood = closestEnemy.transform.position.y;
            vectorXZWood = closestEnemy.transform.position.z;*/

            catetoX = vectorXXCamera - vectorXXWood;
            catetoY = vectorXYCamera - vectorXYWood;
            catetoZ = vectorXZCamera - vectorXZWood;

            instantaiatePoint = new Vector3(vectorXXWood - catetoX, (vectorXYWood + 0.5f) - catetoY, vectorXZWood - catetoZ);

            if(PlayerPrefs.GetInt("potion7ACT") == 1)
            {

                vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
                vectorXYCamera = gameObject.GetComponent<Transform>().position.z;

                    catetoX = vectorXXCamera - vectorXXWood;
                    catetoY = vectorXYCamera - vectorXZWood;

                    if (catetoX < 0)
                    {
                        catetoX *= -1;
                    }
                    if (catetoY < 0)
                    {
                        catetoY *= -1;
                    }

                    arcTangente = (Mathf.Atan(catetoY / catetoX));
                    
                    arcTangente = (arcTangente * 180) / Mathf.PI;
                    
                    angA = arcTangente;

                    if (angA < 0)
                    {
                        angA *= -1;
                    }

                    angA = 90 - angA;

                    if (vectorXXCamera > vectorXXWood)
                    {
                        if(vectorXYCamera < vectorXZWood)
                        {
                            angA = angA * (-1);

                        }
                    }
                    if (vectorXXCamera < vectorXXWood)
                    {
                        if (vectorXYCamera > vectorXZWood)
                        {
                            angA = (angA * -1) + 180;
                        }
                    }
                    if (vectorXXCamera > vectorXXWood)
                    {
                        if (vectorXYCamera > vectorXZWood)
                        {
                            angA = (angA) - 180;
                        }
                    }

                    gameObject.transform.eulerAngles = new Vector3(0, angA, 0);
            }
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
        if (collider.transform.tag == "barrier")
        {
            Destroy(gameObject);
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
        }
        if (collider.transform.tag == "barrier")
        {
            Destroy(gameObject);
        }
    }
}
