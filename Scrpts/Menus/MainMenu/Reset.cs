using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    
    public void reset()
    {
        PlayerPrefs.SetInt("totalMoney", 0);                //HOW MUCH MONEY I HAVE
        PlayerPrefs.SetInt("totalGem", 0);                //HOW MUCH MONEY I HAVE

        PlayerPrefs.SetInt("weapon", 0);                    //Weapon Useing
            PlayerPrefs.SetInt("weapon01Level", 1);
            PlayerPrefs.SetInt("weapon01Damage", 0);
            PlayerPrefs.SetInt("weapon01Speed", 0);
        PlayerPrefs.SetInt("weaponB1", 0);                  //If i Have Bought or Not the Weapon
        PlayerPrefs.SetInt("weaponB2", 0);
        PlayerPrefs.SetInt("weaponB3", 0);
        PlayerPrefs.SetInt("weaponB4", 0);
            PlayerPrefs.SetInt("weaponDamageLevel", 0);      //ADD COIN Damage Weapon

        PlayerPrefs.SetInt("armorUsing", -1);                //Armor Useing
        PlayerPrefs.SetInt("armor02Bought", 0);              //If i Have Bought or Not the Weapon
        PlayerPrefs.SetInt("armor03Bought", 0);
        PlayerPrefs.SetInt("armor04Bought", 0);

        PlayerPrefs.SetInt("shieldUsing", 0);                //SHIELD Useing
        PlayerPrefs.SetInt("howMuchShields", 0);             //HOW MUCH SHIELDS AM I USING
        PlayerPrefs.SetInt("shield02Bought", 0);             //If i Have Bought or Not the Weapon
        PlayerPrefs.SetInt("shield03Bought", 0);
        PlayerPrefs.SetInt("shield04Bought", 0);

        PlayerPrefs.SetInt("stopArrow", 0);             //SOUNDS
        PlayerPrefs.SetInt("evilSound", 0);
        PlayerPrefs.SetInt("ambientMusic", 0);
        PlayerPrefs.SetInt("meSound", 0);

        PlayerPrefs.SetInt("toggleCamera", 5);          //Camera Angle

        PlayerPrefs.SetInt("potion0", 0);               //Potions MessedUp
        PlayerPrefs.SetInt("potion1", 0);
            PlayerPrefs.SetInt("potion1ACT", 0);
        PlayerPrefs.SetInt("potion2", 0);
            PlayerPrefs.SetInt("potion2ACT", 0);
        PlayerPrefs.SetInt("potion3", 0);
            PlayerPrefs.SetInt("potion3ACT", 0);
        PlayerPrefs.SetInt("potion4", 0);
            PlayerPrefs.SetInt("potion4ACT", 0);
        PlayerPrefs.SetInt("potion5", 0);
        PlayerPrefs.SetInt("potion6", 0);
            PlayerPrefs.SetInt("potion6ACT", 0);
        PlayerPrefs.SetInt("potion7", 0);
            PlayerPrefs.SetInt("potion7ACT", 0);
        PlayerPrefs.SetInt("potion8", 0);
            PlayerPrefs.SetInt("potion8ACT", 0);
        PlayerPrefs.SetInt("potion9", 0);
        PlayerPrefs.SetInt("potion10", 0);
        PlayerPrefs.SetInt("potion11", 0);
        PlayerPrefs.SetInt("potion12", 0);
            PlayerPrefs.SetInt("potion12ACT", 0);
        PlayerPrefs.SetInt("potion13", 0);


        PlayerPrefs.SetInt("levelPower00", 0);
        PlayerPrefs.SetInt("levelPower01", 0);
        PlayerPrefs.SetInt("levelPower02", 0);
        PlayerPrefs.SetInt("levelPower03", 0);
        PlayerPrefs.SetInt("levelPower04", 0);
        PlayerPrefs.SetInt("levelPower05", 0);
        PlayerPrefs.SetInt("levelPower06", 0);
        PlayerPrefs.SetInt("levelPower07", 0);

        PlayerPrefs.SetInt("stageShopInG", 0);          //DETECTS WHERE I AM IN SHOP IN GAME
        PlayerPrefs.SetInt("stageWeapon", 0);
        PlayerPrefs.SetInt("stageShield", 0);
        PlayerPrefs.SetInt("stageArmor", 0);

        PlayerPrefs.SetInt("whichLevelAmI", 1);         //Level I Chose
        PlayerPrefs.SetInt("howMuchsLevelsUL", 1);      //How Much levels do I have Unlocked
        PlayerPrefs.SetInt("level1", 1);                //Levels I Have Unlocked
        PlayerPrefs.SetInt("level2", 0);
        PlayerPrefs.SetInt("level3", 0);
        PlayerPrefs.SetInt("level4", 0);

        PlayerPrefs.SetInt("stageLevel1", -1);      //How Much Altar Have Been Built
        PlayerPrefs.SetInt("stageLevel2", -1);
        PlayerPrefs.SetInt("stageLevel3", -1);
        PlayerPrefs.SetInt("stageLevel4", -1);

        PlayerPrefs.SetInt("ActuallyWon", 0);       //detect When u won
                
    }

    public void moneyAdd()
    {
        PlayerPrefs.SetInt("totalMoney", 10000000);
        PlayerPrefs.SetInt("level2", 1);                
        /*PlayerPrefs.SetInt("level3", 1);
        PlayerPrefs.SetInt("level4", 1);*/
    }
}
