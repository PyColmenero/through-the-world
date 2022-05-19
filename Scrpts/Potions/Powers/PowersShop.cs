using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowersShop : MonoBehaviour
{

    int  price00, price01, price02, price03,price04, price05, price06, price07;
    public Text priceAmmountText00, priceAmmountText01, priceAmmountText02, priceAmmountText03, priceAmmountText04, priceAmmountText05, priceAmmountText06, priceAmmountText07;
    public Text priceText00, priceText01, priceText02, priceText03, priceText04, priceText05, priceText06, priceText07;
    public Text infoText00;

    public GameObject maxLevel00, maxLevel01, maxLevel02, maxLevel03, maxLevel04, maxLevel05, maxLevel06, maxLevel07;
    public GameObject noMaxLevel00, noMaxLevel01, noMaxLevel02, noMaxLevel03, noMaxLevel04, noMaxLevel05, noMaxLevel06, noMaxLevel07;

    

    void Start()
    {
        maxLevel00.SetActive(false);
        maxLevel01.SetActive(false);
        maxLevel02.SetActive(false);
        maxLevel03.SetActive(false);
        maxLevel04.SetActive(false);
        maxLevel05.SetActive(false);
        maxLevel06.SetActive(false);
        maxLevel07.SetActive(false);
        

        // P00 SWITCH
        switch(PlayerPrefs.GetInt("levelPower00"))
        {
            case 0:
                        //1000
                        price00 = 20000;
            break;
            case 1:
                        //1200
                        price00 = 100000;
            break;
            case 2:
                        //1500
                        price00 = 250000;
            break;
            case 3:
                        //2000
                        price00 = 500000;
            break;
            case 4:
                        //3000
                        price00 = 1000000;

            break;
            case 5:
                        maxLevel00.SetActive(true);
                        noMaxLevel00.SetActive(false);
                        
            break;
        }


        // P01 SWITCH

        switch(PlayerPrefs.GetInt("levelPower01"))
        {
            case 0:
                        //1000
                        price01 = 10000;
            break;
            case 1:
                        //1200
                        price01 = 20000;
            break;
            case 2:
                        //1500
                        price01 = 30000;
            break;
            case 3:
                        //2000
                        price01 = 50000;
            break;
            case 4:
                        //3000
                        price01 = 100000;
            break;
            case 5:
                        //5000
                        price01 = 150000;
            break;
            case 6:
                        //5000
                        price01 = 200000;
            break;
            case 7:
                        //5000
                        price01 = 300000;
            break;
            case 8:
                        //5000
                        maxLevel01.SetActive(true);
                        noMaxLevel01.SetActive(false);
            break;
        
        }

        //P02 SW
        switch(PlayerPrefs.GetInt("levelPower02"))
        {
            case 0:
                price02 = 300000;
            break;
            case 1:
                maxLevel02.SetActive(true);
                noMaxLevel02.SetActive(false);
            break;
        }

        //P03 SW
        switch(PlayerPrefs.GetInt("levelPower03"))
        {
            case 0:
                        //1000
                        price03 = 20000;
            break;
            case 1:
                        //1200
                        price03 = 30000;
            break;
            case 2:
                        //1500
                        price03 = 40000;
            break;
            case 3:
                        //2000
                        price03 = 50000;
            break;
            case 4:
                        //3000
                        price03 = 70000;
            break;
            case 5:
                        //5000
                        maxLevel03.SetActive(true);
                        noMaxLevel03.SetActive(false);
            break;
        }

        //P04 SW
        switch(PlayerPrefs.GetInt("levelPower04"))
        {
            case 0:
                        //1000
                        price04 = 10000;
            break;
            case 1:
                        //1200
                        price04 = 30000;
            break;
            case 2:
                        //1500
                        price04 = 40000;
            break;
            case 3:
                        //2000
                        price04 = 60000;
            break;
            case 4:
                        //3000
                        price04 = 100000;
            break;
            case 5:
                        //5000
                        maxLevel04.SetActive(true);
                        noMaxLevel04.SetActive(false);
            break;

        }

        //P05 SW
        switch(PlayerPrefs.GetInt("levelPower05"))
        {
            case 0:
                        //1000
                        price05 = 30000;
            break;
            case 1:
                        //1200
                        price05 = 50000;
            break;
            case 2:
                        //1500
                        price05 = 100000;
            break;
            case 3:
                        //2000
                        maxLevel05.SetActive(true);
                        noMaxLevel05.SetActive(false);
            break;
        }

        //P06 SW

        switch(PlayerPrefs.GetInt("levelPower06"))
        {
            case 0:
                        //1000
                        price06 = 100000;
            break;
            case 1:
                        //1200
                        price06 = 120000;
            break;
            case 2:
                        //1500
                        price06 = 135000;
            break;
            case 3:
                        //2000
                        price06 = 150000;
            break;
            case 4:
                        //2000
                        maxLevel06.SetActive(true);
                        noMaxLevel06.SetActive(false);
            break;
        }

        //P07 SW
        switch(PlayerPrefs.GetInt("levelPower07"))
        {
            case 0:
                        //1000
                        price07 = 100000;
            break;
            case 1:
                        //1200
                        maxLevel07.SetActive(true);
                        noMaxLevel07.SetActive(false);
            break;

        }
    }


    void Update()
    {
        priceAmmountText00.text = " Level " + PlayerPrefs.GetInt("levelPower00") + "    ";
        priceAmmountText01.text = " Level " + PlayerPrefs.GetInt("levelPower01") + "    ";
        priceAmmountText02.text = " Level " + PlayerPrefs.GetInt("levelPower02") + "    ";
        priceAmmountText03.text = " Level " + PlayerPrefs.GetInt("levelPower03") + "    ";
        priceAmmountText04.text = " Level " + PlayerPrefs.GetInt("levelPower04") + "    ";
        priceAmmountText05.text = " Level " + PlayerPrefs.GetInt("levelPower05") + "    ";
        priceAmmountText06.text = " Level " + PlayerPrefs.GetInt("levelPower06") + "    ";
        priceAmmountText07.text = " Level " + PlayerPrefs.GetInt("levelPower07") + "    ";

        priceText00.text = price00 + "         ";
        priceText01.text = price01 + "    ";
        priceText02.text = price02 + "    ";
        priceText03.text = price03 + "    ";
        priceText04.text = price04 + "    ";
        priceText05.text = price05 + "    ";
        priceText06.text = price06 + "    ";
        priceText07.text = price07 + "    ";
    }
    public Swipe swipe;
    public VerticalSwipe verticalSwipe;

    

    public void BuyPower00()
    {
        if(PlayerPrefs.GetInt("levelPower00") < 5 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower00"))
            {
                case 0:
                            //1000
                            price00 = 20000;
                break;
                case 1:
                            //1200
                            price00 = 100000;
                break;
                case 2:
                            //1500
                            price00 = 250000;
                break;
                case 3:
                            //2000
                            price00 = 500000;
                break;
                case 4:
                            //3000
                            price00 = 1000000;
                break;
                case 5:
                            //5000
                            maxLevel00.SetActive(true);
                            noMaxLevel00.SetActive(false);
                break;
            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price00)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price00);
                PlayerPrefs.SetInt("levelPower00", PlayerPrefs.GetInt("levelPower00") + 1);
            
            }

            switch(PlayerPrefs.GetInt("levelPower00"))
            {
                case 0:
                            //1000
                            price00 = 20000;
                break;
                case 1:
                            //1200
                            price00 = 100000;
                break;
                case 2:
                            //1500
                            price00 = 250000;
                break;
                case 3:
                            //2000
                            price00 = 500000;
                break;
                case 4:
                            //3000
                            price00 = 1000000;
                break;
                case 5:
                            //5000
                            maxLevel00.SetActive(true);
                            noMaxLevel00.SetActive(false);
                break;
            }
        }
    }

    public void BuyPower01()
    {
        if(PlayerPrefs.GetInt("levelPower01") < 8 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower01"))
            {
                case 0:
                            //1000
                            price01 = 10000;
                break;
                case 1:
                            //1200
                            price01 = 20000;
                break;
                case 2:
                            //1500
                            price01 = 30000;
                break;
                case 3:
                            //2000
                            price01 = 50000;
                break;
                case 4:
                            //3000
                            price01 = 100000;
                break;
                case 5:
                            //5000
                            price01 = 150000;
                break;
                case 6:
                            //5000
                            price01 = 200000;
                break;
                case 7:
                            //5000
                            price01 = 300000;
                break;
                case 8:
                            //5000
                            maxLevel01.SetActive(true);
                            noMaxLevel01.SetActive(false);
                break;
            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price01)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price01);
                PlayerPrefs.SetInt("levelPower01", PlayerPrefs.GetInt("levelPower01") + 1);

            }

            switch(PlayerPrefs.GetInt("levelPower01"))
            {
                case 0:
                            //1000
                            price01 = 10000;
                break;
                case 1:
                            //1200
                            price01 = 20000;
                break;
                case 2:
                            //1500
                            price01 = 30000;
                break;
                case 3:
                            //2000
                            price01 = 50000;
                break;
                case 4:
                            //3000
                            price01 = 100000;
                break;
                case 5:
                            //5000
                            price01 = 150000;
                break;
                case 6:
                            //5000
                            price01 = 200000;
                break;
                case 7:
                            //5000
                            price01 = 300000;
                break;
                case 8:
                            //5000
                            maxLevel01.SetActive(true);
                            noMaxLevel01.SetActive(false);
                break;
            }
        }
    }

    public void BuyPower02()
    {
        if(PlayerPrefs.GetInt("levelPower02") < 1 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower02"))
            {
                case 0:
                    price02 = 300000;
                break;
                case 1:
                        maxLevel02.SetActive(true);
                        noMaxLevel02.SetActive(false);
                break;
            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price02 && PlayerPrefs.GetInt("levelPower02") == 0)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price02);
                PlayerPrefs.SetInt("levelPower02", PlayerPrefs.GetInt("levelPower02") + 1);
                PlayerPrefs.SetInt("potion2ACT", 1);
            }
            switch(PlayerPrefs.GetInt("levelPower02"))
            {
                case 0:
                    price02 = 300000;
                break;
                case 1:
                    maxLevel02.SetActive(true);
                    noMaxLevel02.SetActive(false);
                break;
            }
        }
    }

    public void BuyPower03()
    {
        if(PlayerPrefs.GetInt("levelPower03") < 5 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower03"))
            {
                case 0:
                            //1000
                            price03 = 20000;
                break;
                case 1:
                            //1200
                            price03 = 30000;
                break;
                case 2:
                            //1500
                            price03 = 40000;
                break;
                case 3:
                            //2000
                            price03 = 50000;
                break;
                case 4:
                            //3000
                            price03 = 100000;
                break;
                case 5:
                            //5000
                        maxLevel03.SetActive(true);
                        noMaxLevel03.SetActive(false);
                break;

            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price03)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price03);
                PlayerPrefs.SetInt("levelPower03", PlayerPrefs.GetInt("levelPower03") + 1);

            }
            switch(PlayerPrefs.GetInt("levelPower03"))
            {
                case 0:
                            //1000
                            price03 = 20000;
                break;
                case 1:
                            //1200
                            price03 = 30000;
                break;
                case 2:
                            //1500
                            price03 = 40000;
                break;
                case 3:
                            //2000
                            price03 = 50000;
                break;
                case 4:
                            //3000
                            price03 = 100000;
                break;
                case 5:
                            //5000
                            maxLevel03.SetActive(true);
                        noMaxLevel03.SetActive(false);
                break;

            }
        }
    }

    public void BuyPower04()
    {
        if(PlayerPrefs.GetInt("levelPower04") < 5 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower04"))
            {
                case 0:
                            //1000
                            price04 = 10000;
                break;
                case 1:
                            //1200
                            price04 = 30000;
                break;
                case 2:
                            //1500
                            price04 = 40000;
                break;
                case 3:
                            //2000
                            price04 = 60000;
                break;
                case 4:
                            //3000
                            price04 = 100000;
                break;
                case 5:
                            //5000
                            maxLevel04.SetActive(true);
                        noMaxLevel04.SetActive(false);
                break;

            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price04)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price04);
                PlayerPrefs.SetInt("levelPower04", PlayerPrefs.GetInt("levelPower04") + 1);
            }
            switch(PlayerPrefs.GetInt("levelPower04"))
            {
                case 0:
                            //1000
                            price04 = 10000;
                break;
                case 1:
                            //1200
                            price04 = 30000;
                break;
                case 2:
                            //1500
                            price04 = 40000;
                break;
                case 3:
                            //2000
                            price04 = 60000;
                break;
                case 4:
                            //3000
                            price04 = 100000;
                break;
                case 5:
                            //5000
                            maxLevel04.SetActive(true);
                        noMaxLevel04.SetActive(false);
                break;

            }
        }
    }

    public void BuyPower05()
    {
        if(PlayerPrefs.GetInt("levelPower05") < 3 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower05"))
            {
                case 0:
                            //1000
                            price05 = 30000;
                break;
                case 1:
                            //1200
                            price05 = 50000;
                break;
                case 2:
                            //1500
                            price05 = 100000;
                break;
                case 3:
                            //2000
                            maxLevel05.SetActive(true);
                        noMaxLevel05.SetActive(false);
                break;
            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price05)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price05);
                PlayerPrefs.SetInt("levelPower05", PlayerPrefs.GetInt("levelPower05") + 1);

            }
            switch(PlayerPrefs.GetInt("levelPower05"))
            {
                case 0:
                            //1000
                            price05 = 30000;
                break;
                case 1:
                            //1200
                            price05 = 50000;
                break;
                case 2:
                            //1500
                            price05 = 100000;
                break;
                case 3:
                            //2000
                            maxLevel05.SetActive(true);
                        noMaxLevel05.SetActive(false);
                break;
            }
        }
    }

    public void BuyPower06()
    {
        if(PlayerPrefs.GetInt("levelPower06") < 4 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower06"))
            {
                case 0:
                            //1000
                            price06 = 100000;
                break;
                case 1:
                            //1200
                            price06 = 120000;
                break;
                case 2:
                            //1500
                            price06 = 135000;
                break;
                case 3:
                            //2000
                            price06 = 150000;
                break;
                case 4:
                            //2000
                            maxLevel06.SetActive(true);
                        noMaxLevel06.SetActive(false);
                break;
            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price06)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price06);
                PlayerPrefs.SetInt("levelPower06", PlayerPrefs.GetInt("levelPower06") + 1);

            }

            switch(PlayerPrefs.GetInt("levelPower06"))
            {
                case 0:
                            //1000
                            price06 = 100000;
                break;
                case 1:
                            //1200
                            price06 = 120000;
                break;
                case 2:
                            //1500
                            price06 = 135000;
                break;
                case 3:
                            //2000
                            price06 = 150000;
                break;
                case 4:
                            //2000
                            maxLevel06.SetActive(true);
                        noMaxLevel06.SetActive(false);
                break;
            }
        }
    }

    public void BuyPower07()
    {
        if(PlayerPrefs.GetInt("levelPower07") < 1 && swipe.hSwipe == false && verticalSwipe.vSwipe == false)
        {
            switch(PlayerPrefs.GetInt("levelPower07"))
            {
                case 0:
                    //1000
                    price07 = 100000;
                break;
                case 1:
                    //1200
                    maxLevel07.SetActive(true);
                        noMaxLevel07.SetActive(false);
                break;

            }

            if(PlayerPrefs.GetInt("totalMoney") >=  price07)
            {
                
                PlayerPrefs.SetInt("totalMoney" , PlayerPrefs.GetInt("totalMoney") - price07);
                PlayerPrefs.SetInt("levelPower07", PlayerPrefs.GetInt("levelPower07") + 1);

            }
            switch(PlayerPrefs.GetInt("levelPower07"))
            {
                case 0:
                    //1000
                    price07 = 100000;
                break;
                case 1:
                    //1200
                    maxLevel07.SetActive(true);
                        noMaxLevel07.SetActive(false);
                break;

            }
        }
    }


}
