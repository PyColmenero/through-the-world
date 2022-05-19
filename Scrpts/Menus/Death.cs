using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    float timer;
    public GameObject panel, text, button;
    void Start()
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        panel.GetComponent<Animator>().SetBool("Death", true);
        text.GetComponent<Animator>().SetBool("Death", true);
        timer += Time.deltaTime;
        if(timer >= 0.5f)
        {
            button.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
