using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigoBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float angA;
    float catetoX, catetoZ;
    float arcTangente;

    float bulletX, bulletY, bulletZ;
    float mouseX, mouseY, mouseZ;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit info))
        {
            mouseX = info.collider.transform.position.x;
            mouseY = info.collider.transform.position.y;
            mouseZ = info.collider.transform.position.z;
        }

        bulletX = gameObject.transform.position.x;
        bulletY = gameObject.transform.position.y;
        bulletZ = gameObject.transform.position.z;



            catetoX = bulletX - mouseX;
            catetoZ = bulletZ - mouseZ;

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

            if (bulletX < mouseX)
            {
                if(bulletZ < mouseZ)
                {
                    angA = angA * (-1);

                }
            }
            if (bulletX < mouseX)
            {
                if (bulletZ > mouseZ)
                {
                    angA = (angA) -180;
                }
            }
            if (bulletX > mouseX)
            {
                if (bulletZ > mouseZ)
                {
                    angA = (angA * -1) + 180;
                }
            }


            gameObject.transform.eulerAngles = new Vector3(0, angA, 0);
            //transform.RotateAround(transform.position, Vector3.back, angA)
            Debug.Log("Angulo: " + angA);
            Debug.Log("Catetos  " + catetoX + " , " + catetoZ);
            Debug.Log("Raton  " + mouseX  + " , " + mouseY);
            Debug.Log("aTang " + arcTangente);
            Debug.Log("  ");

        }
    }   
}
