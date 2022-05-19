using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShieldsMM : MonoBehaviour
{
    public GameObject wp0, wp1, wp2, wp3;
     int shieldM = 0;


     public GameObject price2, price3, price4, use1, use2, use3, use4;
     public AudioSource noMoney, yesMoney;

    void Start()
    {

        //PONER TU ARMADURA QUE USAS AL INICAR JUEGO EN LA TIENDA

        use1.SetActive(true);

        switch(PlayerPrefs.GetInt("shieldUsing"))
        {
            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                shieldM = 0;
                break;

            case 1:
                shieldM = 1;
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 2:
                shieldM = 2;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                break;

            case 3:
                shieldM = 3;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                break;
        }
    }

    void Update()
    {
        PlayerPrefs.SetInt("stageShield", shieldM);
        //SOLO PONER EL ARMA QUE ESTAS BUSCANDO CON FLECHAS
        switch(shieldM)
        {
            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 1:
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 2:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                break;

            case 3:
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                break;
        }


        //WHITH shield DO I HAVE BOUGHT BUTTONS

        if(PlayerPrefs.GetInt("shield02Bought") == 1)
        {
            use2.SetActive(true);
            price2.SetActive(false);
        }
        else
        {
            use2.SetActive(false);
            price2.SetActive(true);
        }

        if(PlayerPrefs.GetInt("shield03Bought") == 1)
        {
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            use3.SetActive(false);
            price3.SetActive(true);
        }

        if(PlayerPrefs.GetInt("shield04Bought") == 1)
        {
            use4.SetActive(true);
            price4.SetActive(false);
        }
        else
        {
            use4.SetActive(false);
            price4.SetActive(true);
        }
    }

    //shield M ES EL shield DEL MENU, DONDE ESTAS
    public void rightArrowCW()
    {
        switch (shieldM)
        {
            case 0:
                shieldM = 1;
                break;
            case 1:
                shieldM = 2;
                break;
            case 2:
                shieldM = 3;
                break;
            case 3:
                shieldM = 0;
                break;
        }

    }
    public void leftArrowCW()
    {
        switch (shieldM)
        {
            case 0:
                shieldM = 3;
                break;
            case 1:
                shieldM = 0;
                break;
            case 2:
                shieldM = 1;
                break;
            case 3:
                shieldM = 2;
                break;
        }
    }

    public void useThisshield()
    {
        switch(shieldM)
        {
            case 0:
                PlayerPrefs.SetInt("shieldUsing", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("shieldUsing", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("shieldUsing", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("shieldUsing", 3);
                break;
        }
    }


    public void buyshieldGun2()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 50000)
        {
            PlayerPrefs.SetInt("shieldUsing", 1);
            PlayerPrefs.SetInt("shield02Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 50000);
            yesMoney.Play();
            use2.SetActive(true);
            price2.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }
    public void buyshieldGun3()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 300000)
        {
            PlayerPrefs.SetInt("shieldUsing", 2);
            PlayerPrefs.SetInt("shield03Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 300000);
            yesMoney.Play();
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }

    public void buyshieldGun4()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 650000)
        {
            PlayerPrefs.SetInt("shieldUsing", 3);
            PlayerPrefs.SetInt("shield04Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 650000);
            yesMoney.Play();
            use4.SetActive(true);
            price4.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }
}
