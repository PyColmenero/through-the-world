using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyG : MonoBehaviour
{
    public Text moneyG, gemG;
    public LIFE lIFE;
    public MONEY mONEY;
    public Text maxHealth;


    // Update is called once per frame
    void Update()
    {
        moneyG.text    = mONEY.moneyAmount + " ";
        gemG.text    = mONEY.gemAmount + " ";
    }
}
