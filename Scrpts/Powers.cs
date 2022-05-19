using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{

    float timer;
    void Awake()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gameObject.GetComponent<Animator>().SetBool("zoom", true);
        if(timer >= 1)
        {
            gameObject.GetComponent<Animator>().SetBool("zoom", false);
            timer = 0;
            gameObject.SetActive(false);
            
        } 
    }
}
