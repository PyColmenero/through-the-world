using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{

    public PlayerControler playerControler;
    public GameObject scrollBar;
    public float ang;
    Scrollbar cameraAng;
    double toggle;
    float x = 0, y = 0;
    // Start is called before the first frame update
    void Start()
    {
        ang = 65;
        switch(PlayerPrefs.GetInt("toggleCamera"))
        {
            case 0:
                scrollBar.GetComponent<Scrollbar>().value = 0.05f;
                break;
            case 1:
                scrollBar.GetComponent<Scrollbar>().value = 0.1f;
                break;
            case 2:
                scrollBar.GetComponent<Scrollbar>().value = 0.2f;
                break;
            case 3:
                scrollBar.GetComponent<Scrollbar>().value = 0.3f;
                break;
            case 4:
                scrollBar.GetComponent<Scrollbar>().value = 0.4f;
                break;
            case 5:
                scrollBar.GetComponent<Scrollbar>().value = 0.5f;
                break;
            case 6:
                scrollBar.GetComponent<Scrollbar>().value = 0.6f;
                break;
            case 7:
                scrollBar.GetComponent<Scrollbar>().value = 0.7f;
                break;
            case 8:
                scrollBar.GetComponent<Scrollbar>().value = 0.8f;
                break;
            case 9:
                scrollBar.GetComponent<Scrollbar>().value = 0.9f;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        toggle = 0.055555557832121;
        if(scrollBar.GetComponent<Scrollbar>().value < toggle)
        {
            ang = 80f;
            x = -3.5f;
            y = -3;
            PlayerPrefs.SetInt("toggleCamera", 0);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle && scrollBar.GetComponent<Scrollbar>().value < toggle*3)
        {
            ang = 75f;
            x = -3;
            y = -1;
            PlayerPrefs.SetInt("toggleCamera", 1);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*3 && scrollBar.GetComponent<Scrollbar>().value < toggle*5)
        {
            ang = 70f;
            x = -2.5f;
            y = -1;
            PlayerPrefs.SetInt("toggleCamera", 2);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*5 && scrollBar.GetComponent<Scrollbar>().value < toggle*7)
        {
            ang = 65f;
            x = -2;
            y = 0;
            PlayerPrefs.SetInt("toggleCamera", 3);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*7 && scrollBar.GetComponent<Scrollbar>().value < toggle*9)
        {
            ang = 60f;
            x = -1;
            y = 1;
            PlayerPrefs.SetInt("toggleCamera", 4);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*9 && scrollBar.GetComponent<Scrollbar>().value < toggle*11)
        {
            ang = 55f;
            x = 0;
            y = 2;
            PlayerPrefs.SetInt("toggleCamera", 5);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*11 && scrollBar.GetComponent<Scrollbar>().value < toggle*13)
        {
            ang = 45f;
            x = 2;
            y = 3.5f;
            PlayerPrefs.SetInt("toggleCamera", 6);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*13 && scrollBar.GetComponent<Scrollbar>().value < toggle*15)
        {
            ang = 40f;
            x = 3.5f;
            y = 4.5f;
            PlayerPrefs.SetInt("toggleCamera", 7);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*15 && scrollBar.GetComponent<Scrollbar>().value < toggle*17)
        {
            ang = 35f;
            x = 4.5f;
            y = 6.5f;
            PlayerPrefs.SetInt("toggleCamera", 8);
        }
        if(scrollBar.GetComponent<Scrollbar>().value >= toggle*17)
        {
            ang = 30f;
            x = 5f;
            y = 7.5f;
            PlayerPrefs.SetInt("toggleCamera", 9);
        }
        
        // -13.5 - 69    - 30"
        // -1.5x - 77.5z - 75" 
        gameObject.transform.eulerAngles = new Vector3(ang, 90f, 0f);
        gameObject.transform.position = new Vector3 (playerControler.pControlerX - 5.5f - x, playerControler.pControlerY + 18.5f - y, gameObject.transform.position.z);
    }



        
}
