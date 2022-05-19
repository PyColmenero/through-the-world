﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletB : MonoBehaviour
{

    float speed = 30.0f;
    float timer, timer2, timerDeath, timerD;
    bool dale;

    Vector3 instantaiatePoint;
    int pull = 0;
    bool stopShoot;
     //TRIGONOMETRIA
    float vectorXXWood, vectorXYWood, vectorXZWood, vectorXXCamera, vectorXYCamera, vectorXZCamera, catetoX, catetoY, catetoZ;
    float bulletX, bulletZ, bulletY, xP, zP;

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
        if(timerD >= 2.5f)
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
                    }
                }
                bulletX = gameObject.transform.position.x;
                bulletY = gameObject.transform.position.y;
                bulletZ = gameObject.transform.position.z;
                xP = bulletX - closestEnemy.transform.position.x;
                zP = bulletZ - closestEnemy.transform.position.z;
                bulletX = bulletX + xP;
                bulletZ = bulletZ + zP;

                //instantaiatePoint = new Vector3(bulletX, gameObject.transform.position.y, bulletZ);

                vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
                vectorXYCamera = gameObject.GetComponent<Transform>().position.y;
                vectorXZCamera = gameObject.GetComponent<Transform>().position.z;

                vectorXXWood = bulletX;
                vectorXYWood = bulletY;
                vectorXZWood = bulletZ;

                catetoX = vectorXXCamera - vectorXXWood;
                catetoY = vectorXYCamera - vectorXYWood;
                catetoZ = vectorXZCamera - vectorXZWood;

                instantaiatePoint = new Vector3(vectorXXWood - catetoX, (vectorXYWood + 0.5f) - catetoY, vectorXZWood - catetoZ);

                dale = true;
                pull++;
                
            }


            if(dale)
            {
//                Debug.Log(instantaiatePoint.x + " , " + instantaiatePoint.y + " , " +  instantaiatePoint.z);
                float step =  speed * Time.deltaTime;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, instantaiatePoint, step);
                //gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, angA, gameObject.transform.eulerAngles.z);
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
        if (collider.transform.tag == "groundStair")
        {
            Destroy(gameObject);
            Debug.Log("Escalon  ");
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
        if (collider.transform.tag == "evil")
        {
            Destroy(gameObject);
            Debug.Log("EvilTouched");
        }
        if (collider.transform.tag == "groundStair")
        {
            Destroy(gameObject);
            Debug.Log("Escalon  ");
        }
        //Destroy(gameObject);
    }
}
