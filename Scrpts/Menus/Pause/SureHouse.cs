using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SureHouse : MonoBehaviour
{
    public Pause pause;
    public GameObject home; 
    bool ya;
    int dos;


    // Update is called once per frame
    void Update()
    {
        if(pause.movePanel == false)
        {
            home.gameObject.SetActive(false);
            ya = true;
        }
        else
        {
            if(ya)
            {
                dos++;
                if(dos >= 10)
                {
                    home.gameObject.SetActive(true);
                    ya = false;
                }
            }
        }
    }
}
