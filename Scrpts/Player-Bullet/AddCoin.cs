using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour
{
    public ShootPC shootPC;
    public PlayerControler playerControler;
    public LIFE lIFE;
    public int whithEffect;
    int bA = 0, sA = 0;
    int minAdds, maxAdds;
    public bool dale;
    int ide;
    public bool random;
    float timerV, timerBug;

    public GameObject barrier;

    public GameObject image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11;

    void Start()
    {
        maxAdds = 9;
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        image7.SetActive(false);
        image8.SetActive(false);
        image9.SetActive(false);
        image10.SetActive(false);
//        image11.SetActive(false);

    }

    void Update()
    {
        timerBug += Time.deltaTime;

        timerV += Time.deltaTime;
        if(timerV >= 2)
        {
            if(dale)
            {
                barrier.transform.position = new Vector3(this.transform.position.x - 1f, this.transform.position.y, 10f);

                for(int k = 0; k < 1; k++)
                {
                    timerV = 0;
                    dale = false;
                    if(random)
                    {
                        whithEffect = Random.Range(1,maxAdds);
                    }

                    if(whithEffect == 1)
                    {
                        //Add Arrows Damage;
                        PlayerPrefs.SetInt("weaponDamgeLevel", PlayerPrefs.GetInt("weaponDamgeLevel") + 1);
                    }
                    if(whithEffect == 2)
                    {
                        //Add Max Health
                        lIFE.maxHealth += (lIFE.maxHealth/100) * 20;
                        lIFE.health += (lIFE.health/100) * 20;
                    }
                    if(whithEffect == 3)
                    {
                        //Remove Shoot Time
                        shootPC.yTimeShoot -= (shootPC.yTimeShoot/100)*30;
                    }
                    if(whithEffect == 4)
                    {
                        //Behind Arrows
                        if(shootPC.forHMDA <= 4)
                        {
                            shootPC.forHMDA += 1;
                        }
                        else
                        {
                            whithEffect = Random.Range(0,maxAdds);
                            k = 0;
                        }

                    }
                    if(whithEffect == 5)
                    {
                        //Add Side Arrows
                        shootPC.sideArrows = true;
                        
                        if(sA != 0)
                        {
                            whithEffect = Random.Range(0,maxAdds);
                            k = 0;
                        }
                        sA++;
                    }
                    if(whithEffect == 6)
                    {
                        //Heal
                        lIFE.health += (lIFE.maxHealth/100) * 25;
                    }
                    if(whithEffect == 7)
                    {
                        //Add Arrow Amount
                        shootPC.forHMA++;
                    }
                    if(whithEffect == 8)
                    {
                        //Add Arrow Life Distance
                        PlayerPrefs.SetInt("lifeBulletDistance", 1);
                    }
                }
            
                switch(whithEffect)
                {
                    case 1:
                        image1.SetActive(true);
                        break;
                    case 2:
                        image2.SetActive(true);
                        break;
                    case 3:
                        image3.SetActive(true);
                        break;
                    case 4:
                        image4.SetActive(true);
                        break;
                    case 5:
                        image5.SetActive(true);
                        break;
                    case 6:
                        image6.SetActive(true);
                        break;
                    case 7:
                        image7.SetActive(true);
                        break;
                    case 8:
                        image8.SetActive(true);
                        break;
                    case 9:
                        image1.SetActive(true);
                        break;
                    case 10:
                        image1.SetActive(true);
                        break;
                }
                //Destroy(gameObject);
                Debug.Log("whithEffect " + whithEffect);
            }
        }

    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "AddCoin")
        {
            if(timerBug >= 2f)
            {
                dale = true;
//                Debug.Log("DAle");
                timerBug = 0;
            }
        }
    }
}
