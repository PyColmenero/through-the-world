using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPotionsGame : MonoBehaviour
{
    public Text text00, text01, text02, text03, text04, text05, text06, text07, text08, text09, text10, text11, text12, text13;

    void Start()
    {
        
    }


    void Update()
    {
        if(text00 != null) { text00.text = PlayerPrefs.GetInt("potion0") + " "; }
        
        if(text01 != null) { text01.text = PlayerPrefs.GetInt("potion1") + " "; }
        if(text02 != null) { text02.text = PlayerPrefs.GetInt("potion2") + " "; }
        if(text03 != null) { text03.text = PlayerPrefs.GetInt("potion3") + " "; }
        if(text04 != null) { text04.text = PlayerPrefs.GetInt("potion4") + " "; }
        if(text05 != null) { text05.text = PlayerPrefs.GetInt("potion5") + " "; }
        if(text06 != null) { text06.text = PlayerPrefs.GetInt("potion6") + " "; }
        if(text07 != null) { text07.text = PlayerPrefs.GetInt("potion7") + " "; }
        if(text08 != null) { text08.text = PlayerPrefs.GetInt("potion8") + " "; }
        if(text09 != null) { text09.text = PlayerPrefs.GetInt("potion9") + " "; }
        if(text10 != null) { text10.text = PlayerPrefs.GetInt("potion10") + " "; }
        if(text11 != null) { text11.text = PlayerPrefs.GetInt("potion11") + " "; }
        if(text12 != null) { text12.text = PlayerPrefs.GetInt("potion12") + " "; }
        if(text13 != null) { text13.text = PlayerPrefs.GetInt("potion13") + " "; }
    }
}
