using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletS2 : MonoBehaviour
{

    float speed = 30.0f;
    float timer, timer2, timerDeath, timerD;
    bool pulsar;
    bool dale, chocaCha;
    int k = 0;

    Vector3 instantaiatePoint;
    int pull = 0;
    bool stopShoot;
     //TRIGONOMETRIA
    float vectorXXWood, vectorXYWood, vectorXZWood, vectorXXCamera, vectorXYCamera, vectorXZCamera, catetoX, catetoY, catetoZ, arcTangente, angA;

    float bulletX, bulletZ, xP, zP;

    public GameObject wp0, wp1, wp2, wp3;
    void Start() 
    {
        if(PlayerPrefs.GetInt("potion12ACT") >= 1)
        {
            for(int i = 0; i < PlayerPrefs.GetInt("potion12ACT"); i++)
            {
                speed -= (speed / 10);
            }
        }
        
        switch(PlayerPrefs.GetInt("weapon"))
        {
            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 1:
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 2:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                break;

            case 3:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                break;
        }
     }

    void Update()
    {


        timerD += Time.deltaTime;
        if(timerD >= 0.5f)
        {
            Destroy(gameObject);
        }
            
            if(pull == 0)
            {
                /*Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
                if(Physics.Raycast(ray, out RaycastHit info))
                {*/
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
                        //Debug.DrawLine(transform.position, closestEnemy.transform.position, Color.red);
                    }
                }

  
                bulletX = gameObject.transform.position.x;
                bulletZ = gameObject.transform.position.z;
                xP = closestEnemy.transform.position.x - bulletX;
                zP = closestEnemy.transform.position.z - bulletZ;
                if(xP < 0 && zP < 0)
                {
                    //ZONA C
                    bulletX = bulletX - zP;
                    bulletZ = bulletZ + xP;
                }
                if(xP > 0 && zP > 0)
                {
                    //ZONA B
                    bulletX = bulletX - zP;
                    bulletZ = bulletZ + xP;
                }
                if(xP < 0 && zP > 0)
                {
                    //ZONA A
                    bulletX = bulletX - zP;
                    bulletZ = bulletZ + xP;
                }
                if(xP > 0 && zP < 0)
                {
                    bulletX = bulletX - zP;
                    bulletZ = bulletZ + xP;
                }

                vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
                vectorXYCamera = gameObject.GetComponent<Transform>().position.y;
                vectorXZCamera = gameObject.GetComponent<Transform>().position.z;

                vectorXXWood = bulletX;
                vectorXYWood = vectorXYCamera;
                vectorXZWood = bulletZ;

                catetoX = vectorXXCamera - vectorXXWood;
                catetoY = vectorXYCamera - vectorXYWood;
                catetoZ = vectorXZCamera - vectorXZWood;

                instantaiatePoint = new Vector3(vectorXXWood - catetoX*1, vectorXYWood, vectorXZWood - catetoZ*1);

                //instantaiatePoint = new Vector3(bulletX, gameObject.transform.position.y, bulletZ);                    

                dale = true;
                pull++;
                
                //TRIGONOMETRIA

                vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
                vectorXYCamera = gameObject.GetComponent<Transform>().position.z;

                vectorXXWood = closestEnemy.transform.position.x;
                vectorXYWood = closestEnemy.transform.position.z;

                catetoX = vectorXXCamera - vectorXXWood;
                catetoY = vectorXYCamera - vectorXYWood;

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
                    if(vectorXYCamera < vectorXYWood)
                    {
                        angA = angA * (-1);

                    }
                }
                if (vectorXXCamera < vectorXXWood)
                {
                    if (vectorXYCamera > vectorXYWood)
                    {
                        angA = (angA * -1) + 180;
                    }
                }
                if (vectorXXCamera > vectorXXWood)
                {
                    if (vectorXYCamera > vectorXYWood)
                    {
                        angA = (angA) -180;
                    }
                }
                angA -= 90;

                if(k == 0)
                {
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, angA, gameObject.transform.eulerAngles.z);
                    k++;
                }
                
            }


            if(dale)
            {
                float step =  speed * Time.deltaTime;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, instantaiatePoint, step);
                gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, angA, gameObject.transform.eulerAngles.z);
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
        if(collider.transform.tag == "evil")
        {
            Destroy(gameObject);
        }
        //Destroy(gameObject);
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
        if(collider.transform.tag == "evil")
        {
            Destroy(gameObject);
            Debug.Log("EvilTouched");
        }
        //Destroy(gameObject);
    }
}
