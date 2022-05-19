using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public AudioSource music;
    public GameObject playButtons;
    public GameObject panel;
    public GameObject buttons;
    float timer, timer2;
    bool pause, play = true, play1 = true;
    int animation = 0;
//    bool uno = true;

    public GameObject camera;

    public bool movePanel;

    // Update is called once per frame
    void Update()
    {
        if(pause)
        {
            if(play)
            {
                buttons.SetActive(true);
                panel.SetActive(true);
                animation++;
                if(animation >= 5)
                {
                    play = false;
                    Time.timeScale = 0f;
                    animation = 0;
                }
            }
        }
        else
        {
            if(play1)
            {
                Time.timeScale = 1f;
                buttons.SetActive(false);
                panel.SetActive(false);
                playButtons.SetActive(true);
                play1 = false;
            }
        }
    }

    public void pauseG()
    {
        music.Pause();
        playButtons.SetActive(false);
        pause = true;
        play = true;
    }

    public void pauseP()
    {
        music.Play();
        camera.GetComponent<CameraMove>().enabled = false;
        camera.GetComponent<CameraMove>().enabled = true;
        pause = false;
        play1 = true;

    }

    public bool musicPanel;

    public void musicB()
    {
        musicPanel = true;
    }
    public void musicBC()
    {
        musicPanel = false;
    }

    public void houseB()
    {
        movePanel = true;
    }
    public void houseBF()
    {
        movePanel = false;
    }
    public MONEY mONEY;
    int totalM, totalG;
    public void houseBT()
    {
        totalM = PlayerPrefs.GetInt("totalMoney");
        totalG = PlayerPrefs.GetInt("totalGem");
        PlayerPrefs.SetInt("totalMoney", totalM + mONEY.moneyAmount);
        PlayerPrefs.SetInt("totalMoney", totalG + mONEY.gemAmount);
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
