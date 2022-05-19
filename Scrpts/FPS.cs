using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public float timer;
    public Text fpsText;
    double fps, fpsCS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fps++;
        timer += Time.deltaTime;
        if(timer >= 1)
        {
            fpsCS = fps;
            timer = 0;
            fps = 0;
        }
        fpsText.text = fpsCS + "fps" ;
    }
}
