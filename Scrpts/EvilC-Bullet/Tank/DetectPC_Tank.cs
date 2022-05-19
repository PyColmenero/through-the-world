using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPC_Tank : MonoBehaviour
{
    float timer;


    public GameObject bulletEvil;

    float evilX, evilY, evilZ;

    GameObject player;

    float vectorXXWood, vectorXYWood, vectorXXCamera, vectorXYCamera, arcTangente, catetoX, catetoY;
    public float angA;
    public float speedShootTime = 4;
    int boos;

    void Start()
    {
        //speedShootTime = 0.5f;
    }

    void Update()
    {
        player = GameObject.Find("Player------------------------------------");

        evilX = gameObject.transform.position.x;
        evilY = gameObject.transform.position.y;
        evilZ = gameObject.transform.position.z;

        vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
        vectorXYCamera = gameObject.GetComponent<Transform>().position.z;

            vectorXXWood = player.gameObject.transform.position.x;
            vectorXYWood = player.gameObject.transform.position.z;

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
                    angA = (angA) - 180;
                }
            }

        timer += Time.deltaTime;
        
        if(timer >= speedShootTime)
        {
            if(player.gameObject.transform.position.x < evilX + 30 && player.gameObject.transform.position.x > evilX - 30)
            {
                if(player.gameObject.transform.position.x < evilX + 30 && player.gameObject.transform.position.x >= evilX)
                    {
                        Vector3 position = new Vector3(evilX + 0.5f, evilY + 0.3f, evilZ);
                        Quaternion rotation = new Quaternion();
                        Instantiate(bulletEvil, position, rotation);
                    }

                if(player.gameObject.transform.position.x > evilX - 30 && player.gameObject.transform.position.x < evilX)
                    {
                        Vector3 position = new Vector3(evilX - 0.5f, evilY + 0.3f, evilZ);
                        Quaternion rotation = new Quaternion();
                        Instantiate(bulletEvil, position, rotation);
                    }

                timer = 0;
            }
            else
            {
                timer = 1;
            }
        }
    }
}
