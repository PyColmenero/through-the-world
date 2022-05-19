using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoinDes : MonoBehaviour
{
    float timer;
    bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            timer += Time.deltaTime;
            if(timer >= 0.02)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "player1")
        {
            a = true;
        }
    }
}
