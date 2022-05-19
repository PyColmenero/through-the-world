using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowArrowTramp : MonoBehaviour
{

    float timer;
    public GameObject bulletTramp;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.7f)
        {
            timer = 0;
            Vector3 position = gameObject.transform.position;
            Instantiate(bulletTramp, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
