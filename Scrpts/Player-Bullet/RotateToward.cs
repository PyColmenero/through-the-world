using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToward : MonoBehaviour
{

    float vectorXXWood, vectorXYWood, vectorXXCamera, vectorXYCamera, arcTangente, catetoX, catetoY;
    public float angA, angAB, angAS1, angAS2;
    Vector3 instantaiatePoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
                //Debug.DrawLine(transform.position, closestEnemy.transform.position, Color.red);
                //Debug.Log("DW");
            }
        }

        if(closestEnemy == null)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);;
        }
        else
        {
            
        

        //instantaiatePoint = new Vector3(closestEnemy.transform.position.x, closestEnemy.transform.position.y, closestEnemy.transform.position.z);


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
        angAB = angA + 180;
        angAS1 = angA + 90;
        angAS2 = angA - 90;
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, angA, gameObject.transform.eulerAngles.z);
        }
    }
}
