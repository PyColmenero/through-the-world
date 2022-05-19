using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeaponMM : MonoBehaviour
{

    public GameObject price1, price2, price3, price4, use0, use1, use2, use3, use4;
    
    // Update is called once per frame
    void Update()
    {
        use0.SetActive(true);

        if(PlayerPrefs.GetInt("weaponB1") == 1)
        {
            use1.SetActive(true);
            price1.SetActive(false);
        }
        else
        {
            use1.SetActive(false);
            price1.SetActive(true);
        }

        if(PlayerPrefs.GetInt("weaponB2") == 1)
        {
            use2.SetActive(true);
            price2.SetActive(false);
        }
        else
        {
            use2.SetActive(false);
            price2.SetActive(true);
        }

        if(PlayerPrefs.GetInt("weaponB3") == 1)
        {
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            use3.SetActive(false);
            price3.SetActive(true);
        }

        if(PlayerPrefs.GetInt("weaponB4") == 1)
        {
            use4.SetActive(true);
            price4.SetActive(false);
        }
        else
        {
            use4.SetActive(false);
            price4.SetActive(true);
//            print(PlayerPrefs.GetInt("weaponB4"));
        }
    }

    public AudioSource noMoney, yesMoney;

    public void buyWeaponGun1()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 20000 && PlayerPrefs.GetInt("weaponB1") == 0)
        {
            PlayerPrefs.SetInt("weapon", 1);
            PlayerPrefs.SetInt("weaponB1", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 20000);
            yesMoney.Play();
            use1.SetActive(true);
            price1.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }
    public void buyWeaponGun2()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 100000 && PlayerPrefs.GetInt("weaponB2") == 0)
        {
            PlayerPrefs.SetInt("weapon", 2);
            PlayerPrefs.SetInt("weaponB2", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 100000);
            yesMoney.Play();
            use2.SetActive(true);
            price2.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }
    public void buyWeaponGun3()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 200000 && PlayerPrefs.GetInt("weaponB3") == 0)
        {
            PlayerPrefs.SetInt("weapon", 3);
            PlayerPrefs.SetInt("weaponB3", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 200000);
            yesMoney.Play();
            use3.SetActive(true);
            price3.SetActive(false);
        }
        else
        {
            noMoney.Play();
        }
    }

    public void buyWeaponGun4()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 500000 && PlayerPrefs.GetInt("weaponB4") == 0)
        {
            PlayerPrefs.SetInt("weapon", 4);
            PlayerPrefs.SetInt("weaponB4", 1);
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 500000);
            yesMoney.Play();
            use4.SetActive(true);
            price4.SetActive(false);
            print(PlayerPrefs.GetInt("weaponB4"));
        }
        else
        {
            noMoney.Play();
        }
    }
}
