using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BYParticles : MonoBehaviour
{
    public GameObject children, children1, children11;
    public GameObject children2, children22, children222;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool particlesOn;

    // Update is called once per frame
     void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.02)
        {
            if(gameObject.transform.localScale.x == 1f)
            {
                children.gameObject.SetActive(false);
                children2.gameObject.SetActive(false);
                children1.gameObject.SetActive(false);
                children22.gameObject.SetActive(false);
                children11.gameObject.SetActive(false);
                children222.gameObject.SetActive(false);
            }
            else
            {
                children.gameObject.SetActive(true);
                children2.gameObject.SetActive(true);
                children1.gameObject.SetActive(true);
                children22.gameObject.SetActive(true);
                children11.gameObject.SetActive(true);
                children222.gameObject.SetActive(true);
            }
            //Debug.Log("masa: " + gameObject.GetComponent<Rigidbody>().mass);
            timer = 0;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        /*Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        if(rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.mass = 10f;*/


    }

}