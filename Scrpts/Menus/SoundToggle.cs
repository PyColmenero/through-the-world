using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggle : MonoBehaviour
{

    public AudioSource check1, check2, check3; 
    int i = 0;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void soundToggle()
    {
        i = Random.Range(0,3);

        if(i == 0)
        {
            check1.Play();
        }
        if(i == 1)
        {
            check2.Play();
        }
        if(i == 2)
        {
            check3.Play();
        }
    }
}
