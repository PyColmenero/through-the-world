using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("ActuallyWon", 0);
    }
    bool wiin;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("ActuallyWon") == 1) 
        {
            PlayerPrefs.SetInt("ActuallyWon", 0);
            child.SetActive(true);
            wiin = true;
        }
        if(wiin)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 0.6f)
        {
            Time.timeScale = 0f;
        }
    }
}
