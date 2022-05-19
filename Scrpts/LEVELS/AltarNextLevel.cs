using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarNextLevel : MonoBehaviour
{
    public GameObject potion;
    bool nova;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("ActuallyWon", 0);
    }
    public GameObject uWon, mando;
    // Update is called once per frame
    void Update()
    {
        uWon = GameObject.Find("Win");
        mando = GameObject.Find("PlayButtons");    
        potion = GameObject.Find("Potion1");
        if(nova)
        {
            if(potion != null)
            {
                Destroy(potion);
                switch(PlayerPrefs.GetInt("whichLevelAmI"))
                {
                    case 1:
                        PlayerPrefs.SetInt("level2", 1);
                        PlayerPrefs.SetInt("ActuallyWon", 1);
                        mando.SetActive(false);
                        print("gjirig");
                    break;
                    case 2:
                        PlayerPrefs.SetInt("level3", 1);
                        PlayerPrefs.SetInt("ActuallyWon", 1);
                        mando.SetActive(false);
                    break;
                    case 3:
                        PlayerPrefs.SetInt("level4", 1);
                        PlayerPrefs.SetInt("ActuallyWon", 1);
                        mando.SetActive(false);
                    break;
                    case 4:
                        PlayerPrefs.SetInt("ActuallyWon", 1);
                        mando.SetActive(false);
                        //PlayerPrefs.SetInt("level2", 1);
                    break;
                }
                
            }
            else
            {
                nova = false;
            }
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.transform.tag == "player1")
        {
            nova = true;
            Debug.Log("Holafe");
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "player1")
        {
            nova = true;
            Debug.Log("Holafe");
        }
    }
}
