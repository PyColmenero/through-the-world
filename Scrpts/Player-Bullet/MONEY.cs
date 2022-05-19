using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MONEY : MonoBehaviour
{
    public Text totalM0, totalG0;

    void Update()
    {
        if(totalM0 != null)
        {
            totalM0.text = PlayerPrefs.GetInt("totalMoney", 0) + "€ ";
            totalG0.text = PlayerPrefs.GetInt("totalGem", 0) + "€ ";
        }
    }

    public int moneyAmount, gemAmount;
    int mA;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "coin")
        {
            mA = Random.Range(5,10);
            moneyAmount += mA;
        }
        if(other.transform.tag == "gem")
        {
            moneyAmount += 1;
        }
    }

}
