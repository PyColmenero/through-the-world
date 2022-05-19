using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("weapon") == 0)
        {
            PlayerPrefs.SetInt("weapon",1);
        }
    }

    public void useWeapon0()
    {
        if(PlayerPrefs.GetInt("weapon") == 1)
        {
            PlayerPrefs.SetInt("weapon", 0);
        }
    }
    public void useWeapon1()
    {
        if(PlayerPrefs.GetInt("weapon") == 0)
        {
            PlayerPrefs.SetInt("weapon", 1);
        }
    }

}

