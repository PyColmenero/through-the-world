using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLLevels : MonoBehaviour
{
    int whereLevelAmI;
    public AudioSource wrong;
    public GameObject level1, level2, level3, level4;
    public GameObject potions1, potions2, potions3, potions4;
    public GameObject weapon1, weapon2, weapon3, weapon4;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        if(PlayerPrefs.GetInt("level1") == 1)
        {
            PlayerPrefs.SetInt("howMuchsLevelsUL", 1);
        }
        if(PlayerPrefs.GetInt("level2") == 1)
        {
            PlayerPrefs.SetInt("howMuchsLevelsUL", 2);
        }
        if(PlayerPrefs.GetInt("level3") == 1)
        {
            PlayerPrefs.SetInt("howMuchsLevelsUL", 3);
        }
        if(PlayerPrefs.GetInt("level4") == 1)
        {
            PlayerPrefs.SetInt("howMuchsLevelsUL", 4);
        }

        switch(PlayerPrefs.GetInt("whichLevelAmI"))
        {
            case 1:
                level1.SetActive(true);
                level2.SetActive(false);
                level3.SetActive(false);
                level4.SetActive(false);



                weapon1.SetActive(true);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                weapon4.SetActive(false);

            break;
            case 2:
                level1.SetActive(false);
                level2.SetActive(true);
                level3.SetActive(false);
                level4.SetActive(false);


                weapon1.SetActive(false);
                weapon2.SetActive(true);
                weapon3.SetActive(false);
                weapon4.SetActive(false);

            break;
            case 3:
                level1.SetActive(false);
                level2.SetActive(false);
                level3.SetActive(true);
                level4.SetActive(false);


                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(true);
                weapon4.SetActive(false);

            break;
            case 4:
                level1.SetActive(false);
                level2.SetActive(false);
                level3.SetActive(false);
                level4.SetActive(true);


                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                weapon4.SetActive(true);

            break;
        }

        whereLevelAmI = PlayerPrefs.GetInt("howMuchsLevelsUL");
    }

    // Update is called once per frame
    void Update()
    {
        switch(whereLevelAmI)
        {
            case 1:
                PlayerPrefs.SetInt("whichLevelAmI", 1);
                level1.SetActive(true);
                level2.SetActive(false);
                level3.SetActive(false);
                level4.SetActive(false);


                weapon1.SetActive(true);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                weapon4.SetActive(false);

            break;
            case 2:
                PlayerPrefs.SetInt("whichLevelAmI", 2);
                level1.SetActive(false);
                level2.SetActive(true);
                level3.SetActive(false);
                level4.SetActive(false);


                weapon1.SetActive(false);
                weapon2.SetActive(true);
                weapon3.SetActive(false);
                weapon4.SetActive(false);
            break;
            case 3:
                PlayerPrefs.SetInt("whichLevelAmI", 3);
                level1.SetActive(false);
                level2.SetActive(false);
                level3.SetActive(true);
                level4.SetActive(false);

                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(true);
                weapon4.SetActive(false);

            break;
            case 4:
                PlayerPrefs.SetInt("whichLevelAmI", 4);
                level1.SetActive(false);
                level2.SetActive(false);
                level3.SetActive(false);
                level4.SetActive(true);

                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                weapon4.SetActive(true);
            break;
        }
    }
    
    public TouchPlayer touchPlayer;
    public GameObject player;

    public void rightLevel()
    {

        /*touchPlayer.jump = true;
        touchPlayer.jump2 = true;
        player.GetComponent<Animator>().SetBool("jumpmm", true);*/

        switch(PlayerPrefs.GetInt("howMuchsLevelsUL"))
        {
            case 1:
                wrong.Play();
            break;
            case 2:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 2;
                    break;
                    case 2:
                        whereLevelAmI = 1;
                    break;
                }
            break;
            case 3:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 2;
                    break;
                    case 2:
                        whereLevelAmI = 3;
                    break;
                    case 3:
                        whereLevelAmI = 1;
                    break;
                }
            break;
            case 4:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 2;
                    break;
                    case 2:
                        whereLevelAmI = 3;
                    break;
                    case 3:
                        whereLevelAmI = 4;
                    break;
                    case 4:
                        whereLevelAmI = 1;
                    break;
                }
            break;
        }
//        print(PlayerPrefs.GetInt("howMuchsLevelsUL"));
    }
    public void leftLevel()
    {
        
        switch(PlayerPrefs.GetInt("howMuchsLevelsUL"))
        {
            
            case 1:
                wrong.Play();
            break;
            case 2:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 2;
                    break;
                    case 2:
                        whereLevelAmI = 1;
                    break;
                }
            break;
            case 3:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 3;
                    break;
                    case 2:
                        whereLevelAmI = 1;
                    break;
                    case 3:
                        whereLevelAmI = 2;
                    break;
                }
            break;
            case 4:
                switch(whereLevelAmI)
                {
                    case 1:
                        whereLevelAmI = 4;
                    break;
                    case 2:
                        whereLevelAmI = 1;
                    break;
                    case 3:
                        whereLevelAmI = 2;
                    break;
                    case 4:
                        whereLevelAmI = 3;
                    break;
                }
            break;
        }
        print(PlayerPrefs.GetInt("howMuchsLevelsUL"));
    }
}
