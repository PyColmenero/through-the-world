using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArmorMM : MonoBehaviour
{
    public GameObject wp0, wp1, wp2, wp3;
     int armorM = 0;


     public GameObject price1, price2, price3, price4, use1, use2, use3, use4;
     public AudioSource noMoney, yesMoney;

    void Start()
    {

        //PONER TU ARMADURA QUE USAS AL INICAR JUEGO EN LA TIENDA

        switch(PlayerPrefs.GetInt("armorUsing"))
        {
             case -1:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                armorM = 0;
                break;

            case 0:
                wp0.SetActive(true);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(false);
                armorM = 0;
                break;

            case 1:
                armorM = 1;
                wp0.SetActive(false);
                wp1.SetActive(true);
                wp2.SetActive(false);
                wp3.SetActive(false);
                break;

            case 2:
                armorM = 2;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(true);
                wp3.SetActive(false);
                break;

            case 3:
                armorM = 3;
                wp0.SetActive(false);
                wp1.SetActive(false);
                wp2.SetActive(false);
                wp3.SetActive(true);
                break;
        }
    }

   
    void Update()
    {
        PlayerPrefs.SetInt("stageArmor", armorM);
        //SOLO PONER EL ARMA QUE ESTAS BUSCANDO CON FLECHAS
        switch(armorM)
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


        //WHITH ARMOR DO I HAVE BOUGHT BUTTONS

        if(PlayerPrefs.GetInt("armor01Bought") == 1)
        {
            use1.SetActive(true);
            price1.SetActive(false);
        }
        else
        {
            use1.SetActive(false);
            price1.SetActive(true);
        }

        if(PlayerPrefs.GetInt("armor02Bought") == 1)
        {
            use2.SetActive(true);
            price2.SetActive(false);
        }
        else
        {
            use2.SetActive(false);
            price2.SetActive(true);
        }

        if(PlayerPrefs.GetInt("armor03Bought") == 1)
        {
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            use3.SetActive(false);
            price3.SetActive(true);
        }

        if(PlayerPrefs.GetInt("armor04Bought") == 1)
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

    //armor M ES EL armor DEL MENU, DONDE ESTAS
    public void rightArrowCW()
    {
        switch (armorM)
        {
            case 0:
                armorM = 1;
                break;
            case 1:
                armorM = 2;
                break;
            case 2:
                armorM = 3;
                break;
            case 3:
                armorM = 0;
                break;


        }

    }
    public void leftArrowCW()
    {
        switch (armorM)
        {
            case 0:
                armorM = 3;
                break;
            case 1:
                armorM = 0;
                break;
            case 2:
                armorM = 1;
                break;
            case 3:
                armorM = 2;
                break;
        }
    }

    public void useThisarmor()
    {
        switch(armorM)
        {
            case 0:
                PlayerPrefs.SetInt("armorUsing", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("armorUsing", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("armorUsing", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("armorUsing", 3);
                break;
            case 4:
                PlayerPrefs.SetInt("armorUsing", 4);
                break;
        }
    }


    public void buyArmorGun1()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 120000)
        {
            PlayerPrefs.SetInt("armorUsing", 1);
            PlayerPrefs.SetInt("armor01Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 120000);
            yesMoney.Play();
            use1.SetActive(true);
            price1.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }
    public void buyArmorGun2()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 50000)
        {
            PlayerPrefs.SetInt("armorUsing", 2);
            PlayerPrefs.SetInt("armor02Bought", 1);
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
    public void buyArmorGun3()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 20000)
        {
            PlayerPrefs.SetInt("armorUsing", 3);
            PlayerPrefs.SetInt("armor03Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 20000);
            yesMoney.Play();
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }

    public void buyArmorGun4()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 200000)
        {
            PlayerPrefs.SetInt("armorUsing", 4);
            PlayerPrefs.SetInt("armor04Bought", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 200000);
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
