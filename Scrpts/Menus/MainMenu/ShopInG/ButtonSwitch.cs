using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    public int stage, stageWeapon, stageShield, stageArmor;

    void Start()
    {
        weapons.SetActive(true);
        armors.SetActive(false);
        shields.SetActive(false);
        PlayerPrefs.SetInt("stageShopInG", 0);
    }

    void Update()
    {
        stage = PlayerPrefs.GetInt("stageShopInG");
        stageShield = PlayerPrefs.GetInt("stageShield");
        stageArmor = PlayerPrefs.GetInt("stageArmor");
        stageWeapon = PlayerPrefs.GetInt("stageWeapon");
    }
    

    public GameObject weapons, armors, shields;
    public void SwitchShopInGame00()
    {
        PlayerPrefs.SetInt("stageShopInG", 0);
        weapons.SetActive(true);
        armors.SetActive(false);
        shields.SetActive(false);
    }

    public void SwitchShopInGame01()
    {
        PlayerPrefs.SetInt("stageShopInG", 1);
        weapons.SetActive(false);
        armors.SetActive(true);
        shields.SetActive(false);
    }

    public void SwitchShopInGame02()
    {
        PlayerPrefs.SetInt("stageShopInG", 2);
        weapons.SetActive(false);
        armors.SetActive(false);
        shields.SetActive(true);
    }
}
