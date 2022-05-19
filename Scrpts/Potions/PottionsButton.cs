using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PottionsButton : MonoBehaviour
{

    public MONEY mONEY;
    public AudioSource bell, wrong;
    public Text text00, text01, text02, text03, text04, text05, text06, text07, text08, text09, text10, text11, text12, text13;
    public Text priceP09Text, priceP10Text, priceP11Text, priceP12Text, priceP13Text;

    int priceP09, priceP10, priceP11, priceP12, priceP13;
    public bool oneTime;
    public int whereAmI, p09, p10;
     

    void Start()
    {
        oneTime = true;
    }
    
    void Update()
    {
        text00.text = PlayerPrefs.GetInt("potion0") + " ";
        text01.text = PlayerPrefs.GetInt("potion1") + " ";
        text02.text = PlayerPrefs.GetInt("potion2") + " ";
        text03.text = PlayerPrefs.GetInt("potion3") + " ";
        text04.text = PlayerPrefs.GetInt("potion4") + " ";
        text05.text = PlayerPrefs.GetInt("potion5") + " ";
        text06.text = PlayerPrefs.GetInt("potion6") + " ";
        text07.text = PlayerPrefs.GetInt("potion7") + " ";
        text08.text = PlayerPrefs.GetInt("potion8") + " ";
        text09.text = PlayerPrefs.GetInt("potion9") + " ";
        text10.text = PlayerPrefs.GetInt("potion10") + " ";
        text11.text = PlayerPrefs.GetInt("potion11") + " ";
        text12.text = PlayerPrefs.GetInt("potion12") + " ";
        text13.text = PlayerPrefs.GetInt("potion13") + " ";

        priceP11 = 3000;
        for(int i = 0; i < PlayerPrefs.GetInt("potion11"); i++)
        {
            priceP11 = (priceP11 / 10) * 15;
            priceP11 += 3000;
        }

        priceP12 = 3000;
        for(int ii = 0; ii < PlayerPrefs.GetInt("potion12"); ii++)
        {
            priceP12 = (priceP12 / 10) * 15;
            priceP12 += 3000;
        }

        priceP13 = 3000;
        for(int iii = 0; iii < PlayerPrefs.GetInt("potion13"); iii++)
        {
            priceP13 = (priceP13 / 10) * 15;
            priceP13 += 3000;
        }

            //POTION 9 VERTICAL
            //POTION 10 HORIZONTAL

            if(PlayerPrefs.GetInt("potion9") == 0 && PlayerPrefs.GetInt("potion10") == 0)
            {
                priceP09 = 7500;
                priceP10 = 7000;
                whereAmI = -1;
            }
            if(PlayerPrefs.GetInt("potion9") == 1 && PlayerPrefs.GetInt("potion10") == 0)
            {
                priceP09 = 15000;
                priceP10 = 28000;
                whereAmI = 0;
            }
            if(PlayerPrefs.GetInt("potion9") == 0 && PlayerPrefs.GetInt("potion10") == 1)
            {
                priceP09 = 30000;
                priceP10 = 14000;
                whereAmI = 1;
            }
            if(PlayerPrefs.GetInt("potion9") == 1 && PlayerPrefs.GetInt("potion10") == 1)
            {
                priceP09 = 50000;
                priceP10 = 50000;
                whereAmI = 2;
            }
            if(PlayerPrefs.GetInt("potion9") == 0 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 60000;
                priceP10 = 50000;
                whereAmI = 3;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 0)
            {
                priceP09 = 50000;
                priceP10 = 60000;
                whereAmI = 4;
            }
            if(PlayerPrefs.GetInt("potion9") == 1 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 100000;
                priceP10 = 50000;
                whereAmI = 5;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 1)
            {
                priceP09 = 60000;
                priceP10 = 100000;
                whereAmI = 6;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 7;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 8;
            }
            if(PlayerPrefs.GetInt("potion9") == 3 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 9;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 3)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 10;
            }
            if(PlayerPrefs.GetInt("potion9") == 3 && PlayerPrefs.GetInt("potion10") == 2)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 11;
            }
            if(PlayerPrefs.GetInt("potion9") == 2 && PlayerPrefs.GetInt("potion10") == 3)
            {
                priceP09 = 100000;
                priceP10 = 100000;
                whereAmI = 11;
            }
            
            p09 = PlayerPrefs.GetInt("potion9");
            p10 = PlayerPrefs.GetInt("potion10");

            oneTime = false;
        
        

         priceP09Text.text = priceP09 + " ";
         priceP10Text.text = priceP10 + " ";
         priceP11Text.text = priceP11 + " ";
         priceP12Text.text = priceP12 + " ";
         priceP13Text.text = priceP13 + " ";
    }

    public Swipe swipe;
    public VerticalSwipe verticalSwipe;

    public void potion00()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 2000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
                PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 2000);
                PlayerPrefs.SetInt("potion0", PlayerPrefs.GetInt("potion0") + 1);
                bell.Play();
                
            }
        }
        else
        {
            wrong.Play();
        }
    }
    public void potion01()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 5000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 5000);
            PlayerPrefs.SetInt("potion1", PlayerPrefs.GetInt("potion1") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion02()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 30000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 30000);
            PlayerPrefs.SetInt("potion2", PlayerPrefs.GetInt("potion2") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion03()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 500)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 500);
            PlayerPrefs.SetInt("potion3", PlayerPrefs.GetInt("potion3") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion04()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 5000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
                PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 5000);
                PlayerPrefs.SetInt("potion4", PlayerPrefs.GetInt("potion4") + 1);
                bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion05()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 3000 && PlayerPrefs.GetInt("potion5") <= (3 - PlayerPrefs.GetInt("levelPower06")))
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 3000);
            PlayerPrefs.SetInt("potion5", PlayerPrefs.GetInt("potion5") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion06()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 1500 && PlayerPrefs.GetInt("potion6") <= 4)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 1500);
            PlayerPrefs.SetInt("potion6", PlayerPrefs.GetInt("potion6") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion07()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 5000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 5000);
            PlayerPrefs.SetInt("potion7", PlayerPrefs.GetInt("potion7") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
    public void potion08()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= 3000)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false && PlayerPrefs.GetInt("levelPower07") == 0)
            {
                PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 3000);
                PlayerPrefs.SetInt("potion8", PlayerPrefs.GetInt("potion8") + 1);
                bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }

    public void potion09()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= priceP09 && PlayerPrefs.GetInt("potion9") <= 3)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - priceP09);
            PlayerPrefs.SetInt("potion9", PlayerPrefs.GetInt("potion9") + 1);
            bell.Play();
            oneTime = true;
            }
        }
        else
        {
            wrong.Play();
        }    
    }

    public void potion10()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= priceP10 && PlayerPrefs.GetInt("potion10") <= 2)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - priceP10);
            PlayerPrefs.SetInt("potion10", PlayerPrefs.GetInt("potion10") + 1);
            bell.Play();
            oneTime = true;
            }
        }
        else
        {
            wrong.Play();
        }    
    }

    public void potion11()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= priceP11 && PlayerPrefs.GetInt("potion11") < 10)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - priceP11);
            PlayerPrefs.SetInt("potion11", PlayerPrefs.GetInt("potion11") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }

    public void potion12()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= priceP12 && PlayerPrefs.GetInt("potion12") < 10)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - priceP12);
            PlayerPrefs.SetInt("potion12", PlayerPrefs.GetInt("potion12") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }

    public void potion13()
    {
        if(PlayerPrefs.GetInt("totalMoney") >= priceP13 && PlayerPrefs.GetInt("potion13") < 10)
        {
            if(swipe.hSwipe == false && verticalSwipe.vSwipe == false)
            {
            PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - priceP13);
            PlayerPrefs.SetInt("potion13", PlayerPrefs.GetInt("potion13") + 1);
            bell.Play();
            }
        }
        else
        {
            wrong.Play();
        }    
    }
}
