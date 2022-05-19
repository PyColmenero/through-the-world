using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsPowers : MonoBehaviour
{
    public int whereAmI = 0;
    public GameObject potions, powers, potionsButton, powersButton;

    public void PotionsPowersButton()
    {
        
        switch(whereAmI)
        {
            case 0: 
            potions.SetActive(true); 
            potionsButton.SetActive(true); 
            powers.SetActive(false);
            powersButton.SetActive(false);
            whereAmI++;
            break;
            case 1: 
            potions.SetActive(false); 
            potionsButton.SetActive(false);
            powers.SetActive(true);
            powersButton.SetActive(true);
            whereAmI--;
            break;
        }
    }
}
