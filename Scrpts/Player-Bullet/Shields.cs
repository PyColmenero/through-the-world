using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{

    public GameObject s00_1, s00_2, s00_3, s00_4, s01_1, s01_2, s01_3, s01_4, s02_1, s02_2, s02_3, s02_4, s03_1, s03_2, s03_3, s03_4;

    void Start()
    {
        s00_1.SetActive(false);
        s00_2.SetActive(false);
        s00_3.SetActive(false);
        s00_4.SetActive(false);

        s01_1.SetActive(false);
        s01_2.SetActive(false);
        s01_3.SetActive(false);
        s01_4.SetActive(false);

        s02_1.SetActive(false);
        s02_2.SetActive(false);
        s02_3.SetActive(false);
        s02_4.SetActive(false);

        s03_1.SetActive(false);
        s03_2.SetActive(false);
        s03_3.SetActive(false);
        s03_4.SetActive(false);

        PlayerPrefs.SetInt("howMuchShields", PlayerPrefs.GetInt("levelPower06"));

        switch(PlayerPrefs.GetInt("levelPower06"))
        {
            case 1:
                PlayerPrefs.GetInt("shieldUsing", 1);
            break;
            case 2:
                PlayerPrefs.GetInt("shieldUsing", 2);
            break;
            case 3:
                PlayerPrefs.GetInt("shieldUsing", 3);
            break;
            case 4:
                PlayerPrefs.GetInt("shieldUsing", 4);
            break;
        }

        switch(PlayerPrefs.GetInt("shieldUsing", 0))
        {
            case 0:
                switch(PlayerPrefs.GetInt("howMuchShields"))
                {
                    case 0:
                        s00_1.SetActive(false);
                        s00_2.SetActive(false);
                        s00_3.SetActive(false);
                        s00_4.SetActive(false);
                    break;
                    case 1:
                        s00_1.SetActive(true);
                        s00_2.SetActive(false);
                        s00_3.SetActive(false);
                        s00_4.SetActive(false);
                    break;
                    case 2:
                        s00_1.SetActive(true);
                        s00_2.SetActive(true);
                        s00_3.SetActive(false);
                        s00_4.SetActive(false);
                    break;
                    case 3:
                        s00_1.SetActive(true);
                        s00_2.SetActive(true);
                        s00_3.SetActive(true);
                        s00_4.SetActive(false);
                    break;
                    case 4:
                        s00_1.SetActive(true);
                        s00_2.SetActive(true);
                        s00_3.SetActive(true);
                        s00_4.SetActive(true);
                    break;
                }
            break;


            case 1:
                switch(PlayerPrefs.GetInt("howMuchShields"))
                {
                    case 0:
                        s01_1.SetActive(false);
                        s01_2.SetActive(false);
                        s01_3.SetActive(false);
                        s01_4.SetActive(false);
                    break;
                    case 1:
                        s01_1.SetActive(true);
                        s01_2.SetActive(false);
                        s01_3.SetActive(false);
                        s01_4.SetActive(false);
                    break;
                    case 2:
                        s01_1.SetActive(true);
                        s01_2.SetActive(true);
                        s01_3.SetActive(false);
                        s01_4.SetActive(false);
                    break;
                    case 3:
                        s01_1.SetActive(true);
                        s01_2.SetActive(true);
                        s01_3.SetActive(true);
                        s01_4.SetActive(false);
                    break;
                    case 4:
                        s01_1.SetActive(true);
                        s01_2.SetActive(true);
                        s01_3.SetActive(true);
                        s01_4.SetActive(true);
                    break;
                }
            break;


            case 2:
                switch(PlayerPrefs.GetInt("howMuchShields"))
                {
                    case 0:
                        s02_1.SetActive(false);
                        s02_2.SetActive(false);
                        s02_3.SetActive(false);
                        s02_4.SetActive(false);
                    break;
                    case 1:
                        s02_1.SetActive(true);
                        s02_2.SetActive(false);
                        s02_3.SetActive(false);
                        s02_4.SetActive(false);
                    break;
                    case 2:
                        s02_1.SetActive(true);
                        s02_2.SetActive(true);
                        s02_3.SetActive(false);
                        s02_4.SetActive(false);
                    break;
                    case 3:
                        s02_1.SetActive(true);
                        s02_2.SetActive(true);
                        s02_3.SetActive(true);
                        s02_4.SetActive(false);
                    break;
                    case 4:
                        s02_1.SetActive(true);
                        s02_2.SetActive(true);
                        s02_3.SetActive(true);
                        s02_4.SetActive(true);
                    break;
                }
            break;


            case 3:
                switch(PlayerPrefs.GetInt("howMuchShields"))
                {
                    case 0:
                        s03_1.SetActive(false);
                        s03_2.SetActive(false);
                        s03_3.SetActive(false);
                        s03_4.SetActive(false);
                    break;
                    case 1:
                        s03_1.SetActive(true);
                        s03_2.SetActive(false);
                        s03_3.SetActive(false);
                        s00_4.SetActive(false);
                    break;
                    case 2:
                        s03_1.SetActive(true);
                        s03_2.SetActive(true);
                        s03_3.SetActive(false);
                        s03_4.SetActive(false);
                    break;
                    case 3:
                        s03_1.SetActive(true);
                        s03_2.SetActive(true);
                        s03_3.SetActive(true);
                        s03_4.SetActive(false);
                    break;
                    case 4:
                        s03_1.SetActive(true);
                        s03_2.SetActive(true);
                        s03_3.SetActive(true);
                        s03_4.SetActive(true);
                    break;
                }
            break;

        }
        
    }

    public PotionsGame potionsGame;

    void Update()
    {
        if(potionsGame != null && potionsGame.shieldChange)
        {
            PlayerPrefs.SetInt("howMuchShields", PlayerPrefs.GetInt("howMuchShields") + 1);
            switch(PlayerPrefs.GetInt("shieldUsing", 0))
            {
                case 0:
                    switch(PlayerPrefs.GetInt("howMuchShields"))
                    {
                        case 0:
                            s00_1.SetActive(false);
                            s00_2.SetActive(false);
                            s00_3.SetActive(false);
                            s00_4.SetActive(false);
                        break;
                        case 1:
                            s00_1.SetActive(true);
                            s00_2.SetActive(false);
                            s00_3.SetActive(false);
                            s00_4.SetActive(false);
                        break;
                        case 2:
                            s00_1.SetActive(true);
                            s00_2.SetActive(true);
                            s00_3.SetActive(false);
                            s00_4.SetActive(false);
                        break;
                        case 3:
                            s00_1.SetActive(true);
                            s00_2.SetActive(true);
                            s00_3.SetActive(true);
                            s00_4.SetActive(false);
                        break;
                        case 4:
                            s00_1.SetActive(true);
                            s00_2.SetActive(true);
                            s00_3.SetActive(true);
                            s00_4.SetActive(true);
                        break;
                    }
                break;


                case 1:
                    switch(PlayerPrefs.GetInt("howMuchShields"))
                    {
                        case 0:
                            s01_1.SetActive(false);
                            s01_2.SetActive(false);
                            s01_3.SetActive(false);
                            s01_4.SetActive(false);
                        break;
                        case 1:
                            s01_1.SetActive(true);
                            s01_2.SetActive(false);
                            s01_3.SetActive(false);
                            s01_4.SetActive(false);
                        break;
                        case 2:
                            s01_1.SetActive(true);
                            s01_2.SetActive(true);
                            s01_3.SetActive(false);
                            s01_4.SetActive(false);
                        break;
                        case 3:
                            s01_1.SetActive(true);
                            s01_2.SetActive(true);
                            s01_3.SetActive(true);
                            s01_4.SetActive(false);
                        break;
                        case 4:
                            s01_1.SetActive(true);
                            s01_2.SetActive(true);
                            s01_3.SetActive(true);
                            s01_4.SetActive(true);
                        break;
                    }
                break;


                case 2:
                    switch(PlayerPrefs.GetInt("howMuchShields"))
                    {
                        case 0:
                            s02_1.SetActive(false);
                            s02_2.SetActive(false);
                            s02_3.SetActive(false);
                            s02_4.SetActive(false);
                        break;
                        case 1:
                            s02_1.SetActive(true);
                            s02_2.SetActive(false);
                            s02_3.SetActive(false);
                            s02_4.SetActive(false);
                        break;
                        case 2:
                            s02_1.SetActive(true);
                            s02_2.SetActive(true);
                            s02_3.SetActive(false);
                            s02_4.SetActive(false);
                        break;
                        case 3:
                            s02_1.SetActive(true);
                            s02_2.SetActive(true);
                            s02_3.SetActive(true);
                            s02_4.SetActive(false);
                        break;
                        case 4:
                            s02_1.SetActive(true);
                            s02_2.SetActive(true);
                            s02_3.SetActive(true);
                            s02_4.SetActive(true);
                        break;
                    }
                break;


                case 3:
                    switch(PlayerPrefs.GetInt("howMuchShields"))
                    {
                        case 0:
                            s03_1.SetActive(false);
                            s03_2.SetActive(false);
                            s03_3.SetActive(false);
                            s03_4.SetActive(false);
                        break;
                        case 1:
                            s03_1.SetActive(true);
                            s03_2.SetActive(false);
                            s03_3.SetActive(false);
                            s00_4.SetActive(false);
                        break;
                        case 2:
                            s03_1.SetActive(true);
                            s03_2.SetActive(true);
                            s03_3.SetActive(false);
                            s03_4.SetActive(false);
                        break;
                        case 3:
                            s03_1.SetActive(true);
                            s03_2.SetActive(true);
                            s03_3.SetActive(true);
                            s03_4.SetActive(false);
                        break;
                        case 4:
                            s03_1.SetActive(true);
                            s03_2.SetActive(true);
                            s03_3.SetActive(true);
                            s03_4.SetActive(true);
                        break;
                    }
                break;

            }
            potionsGame.shieldChange = false;
        }
    }
}
