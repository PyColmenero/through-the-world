using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonMainMenuIDKWGO()
    {
        SceneManager.LoadScene("IDKWGO");

        if(PlayerPrefs.GetInt("levelPower02") == 1)
        {
            PlayerPrefs.SetInt("potion2ACT", 1);
        }
    }
}
