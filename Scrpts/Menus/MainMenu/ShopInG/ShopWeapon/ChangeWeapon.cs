using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{

    //public bool weapon0, weapon1, weapon2, weapon3;
    public GameObject wp0, wp1, wp2, wp3, wp4;
    int whichWeaponAmIUsint;
    void Start()
    {
        //PONER TU ARMA QUE USAS AL INICAR JUEGO EN LA TIENDA

        whichWeaponAmIUsint = PlayerPrefs.GetInt("weapon");
//        Debug.Log("weapon usar = " + whichWeaponAmIUsint);
        switch(PlayerPrefs.GetInt("weapon"))
        {
            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                wp4.SetActive(false);
                weaponM = 0;
                break;

            case 1:
                weaponM = 1;
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 2:
                weaponM = 2;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                wp4.SetActive(false);
                break;

            case 3:
                weaponM = 3;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                wp4.SetActive(false);
                break;
            case 4:
                weaponM = 4;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                wp4.SetActive(true);
                break;
        }
//        Debug.Log("weapon usar = " + whichWeaponAmIUsint);
    }

    int weaponM = 0;
    void Update()
    {
        PlayerPrefs.SetInt("stageWeapon", weaponM);
        //SOLO PONER EL ARMA QUE ESTAS BUSCANDO CON FLECHAS
        switch(weaponM)
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

    //WEAPON M ES EL WEAPON DEL MENU, DONDE ESTAS
    public void rightArrowCW()
    {
        switch (weaponM)
        {
            case 0:
                weaponM = 1;
                break;
            case 1:
                weaponM = 2;
                break;
            case 2:
                weaponM = 3;
                break;
            case 3:
                weaponM = 4;
                break;

            case 4:
                weaponM = 0;
                break;
        }

    }
    public void leftArrowCW()
    {
        switch (weaponM)
        {
            case 0:
                weaponM = 4;
                break;
            case 1:
                weaponM = 0;
                break;
            case 2:
                weaponM = 1;
                break;
            case 3:
                weaponM = 2;
                break;
            case 4:
                weaponM = 3;
                break;
        }
    }

    public void useThisWeapon()
    {
        switch(weaponM)
        {
            case 0:
                PlayerPrefs.SetInt("weapon", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("weapon", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("weapon", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("weapon", 3);
                break;
            case 4:
                PlayerPrefs.SetInt("weapon", 4);
                break;
        }
    }
}
