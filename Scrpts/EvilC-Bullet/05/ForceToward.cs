using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceToward : MonoBehaviour
{
    public bool lava;
    public float thrust;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float vectorXXWood, vectorXYWood, vectorXXCamera, vectorXYCamera, arcTangente, catetoX, catetoY;
    public float angA;
    public GameObject player;

    public float xCS;


    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "groundStair" )
        {
            rb.AddForce(new Vector3(0, 5500f, 0));
        }
        if(other.transform.tag == "decor" )
        {
            rb.AddForce(new Vector3(0, 5500f, 0));
        }
        
    }

    private void OnTriggerEnter(Collider other) 
    {

        if(other.transform.tag == "lava" )
        {
            gameObject.transform.position += new Vector3 (0,2,0);
        }
    }

    public bool staticC;
    // Update is called once per frame
    void Update()
    {
        if(xCS >= gameObject.transform.position.x + 0.2 && xCS <= gameObject.transform.position.x - 0.2)
        {
            xCS = gameObject.transform.position.x;
            staticC = false;
        }
        else
        {
            staticC = true;
            gameObject.transform.position += new Vector3 (0, 10 * Time.deltaTime ,0);
        }
        
        player = GameObject.Find("Player------------------------------------");

        vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
        vectorXYCamera = gameObject.GetComponent<Transform>().position.z;

        vectorXXWood = player.transform.position.x;
        vectorXYWood = player.transform.position.z;

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

        Quaternion direction = this.transform.rotation;

        gameObject.transform.eulerAngles = new Vector3(0, angA, 0);

        rb.AddRelativeForce(Vector3.forward * thrust);
    }
}
