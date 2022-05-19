using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichLevelAmI : MonoBehaviour
{

    public GameObject mapGenerator1, mapGenerator2, mapGenerator3, mapGenerator4;
    public GameObject base1, base2, base3, base4;

    void Start()
    {
        switch(PlayerPrefs.GetInt("whichLevelAmI"))
        {
            case 1:
                mapGenerator1.SetActive(true);
                        base1.SetActive(true);
                mapGenerator2.SetActive(false);
                        base2.SetActive(false);
                // mapGenerator3.SetActive(false);
                //         base3.SetActive(false);
                // mapGenerator4.SetActive(false);
                //         base4.SetActive(false);
            break;
            case 2:
                mapGenerator1.SetActive(false);
                        base1.SetActive(false);
                mapGenerator2.SetActive(true);
                        base2.SetActive(true);
                // mapGenerator3.SetActive(false);
                //         base3.SetActive(false);
                // mapGenerator4.SetActive(false);
                //         base4.SetActive(false);
            break;
            case 3:
                mapGenerator1.SetActive(false);
                        base1.SetActive(false);
                mapGenerator2.SetActive(false);
                        base2.SetActive(false);
                mapGenerator3.SetActive(true);
                        base3.SetActive(true);
                mapGenerator4.SetActive(false);
                        base4.SetActive(false);
            break;
            case 4:
                mapGenerator1.SetActive(false);
                        base1.SetActive(false);
                mapGenerator2.SetActive(false);
                        base2.SetActive(false);
                mapGenerator3.SetActive(false);
                        base3.SetActive(false);
                mapGenerator4.SetActive(true);
                        base4.SetActive(true);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
