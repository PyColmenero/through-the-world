using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhithWeapon : MonoBehaviour
{


    int whichWeaponAmIUsint;
    public GameObject wp0, wp1, wp2, wp3, wp4;

    void Start()
    {
        whichWeaponAmIUsint = PlayerPrefs.GetInt("weapon");
        Debug.Log("weapon usar = " + whichWeaponAmIUsint);

        switch(whichWeaponAmIUsint)
        {
            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                wp4.SetActive(false);
                break;

            case 1:
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                wp4.SetActive(false);
                break;

            case 2:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                wp4.SetActive(false);
                break;

            case 3:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                wp4.SetActive(false);
                break;
            case 4:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                wp4.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
