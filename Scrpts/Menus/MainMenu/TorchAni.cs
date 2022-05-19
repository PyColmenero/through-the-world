using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchAni : MonoBehaviour
{
    float timer;
    int i, i1;

    public GameObject t1, t2, t3, t4, t5;



    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.2f)
        {
            i1 = i;
            i = Random.Range(1,6);
            while(i == i1)
            {
                i = Random.Range(1,6);
            }
            switch(i)
            {
                case 1:
                t1.SetActive(true);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                break;
                case 2:
                t1.SetActive(false);
                t2.SetActive(true);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                break;
                case 3:
                t1.SetActive(false);
                t2.SetActive(false);
                t3.SetActive(true);
                t4.SetActive(false);
                t5.SetActive(false);
                break;
                case 4:
                t1.SetActive(false);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(true);
                t5.SetActive(false);
                break;
                case 5:
                t1.SetActive(false);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(true);
                break;
            }

            timer = 0;
        }
    }
}
