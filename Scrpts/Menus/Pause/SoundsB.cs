using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsB : MonoBehaviour
{

    public Pause pause;
    public GameObject panelSound;

    bool ya;
    int dos;

    void Update()
    {
        if(pause.musicPanel == false)
        {
            panelSound.gameObject.SetActive(false);
            ya = true;
        }
        else
        {
            if(ya)
            {
                dos++;
                if(dos >= 10)
                {
                    panelSound.gameObject.SetActive(true);
                    ya = false;
                }
            }
        }
    }
}
