using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShootPC : MonoBehaviour
{
    public GameObject bullet, knife1, hammer,  bulletBehind,  bulletSide1,  bulletSide2;

    public GameObject rotateB, rotateS1, rotateS2;
    public GameObject evilChas;
    public GameObject shootGO, shootGOB, shootGOS1, shootGOS2;
    public SetBlock setBlock;
    public GameObject player;



    public bool shootButton = false;
    bool shoot1 = true;
    float timerShoot;
    public int bulletType = 0;
    public double yTimeShoot = 0.3;
    public bool sideArrows, behindArrows;
    public int forHMA = 1, forHMDA = 1;
    public float sideX, sideY, sideZ;
    public bool playShoot, soundMonsters;

    public bool timeDestroy;
    public Toggle myToggle0, myToggle1, myToggle2, myToggle3;
    public GameObject meSound0, meSound1;

    float doubleShoot, doubleDShootPlus, doubleDShootStart;

    public GameObject biggerBullet;
    public float timerBiggerBullet;
    bool boolBiggerBullet;
    public float timeBiggerBullet = 0;
    
    void Start()
    {
        doubleShoot = 0;
        doubleDShootPlus = 0;
        if(PlayerPrefs.GetInt("evilSound") == 0)
        {
            soundMonsters = false;
            myToggle0.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            soundMonsters = true;
            myToggle0.GetComponent<Toggle>().isOn = false;
        }

        if(PlayerPrefs.GetInt("stopArrow") == 0)
        {
            playShoot = false;
            myToggle1.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            playShoot = true;
            myToggle1.GetComponent<Toggle>().isOn = false;
        }

        if(PlayerPrefs.GetInt("ambientMusic") == 0)
        {
            music.SetActive(true);
//            Debug.Log("Hey2 " );
            myToggle2.GetComponent<Toggle>().isOn = true;
        }
        else
        {
           // Debug.Log("Hey1 " );
            music.SetActive(false);
            myToggle2.GetComponent<Toggle>().isOn = false;
        }

        if(PlayerPrefs.GetInt("meSound") == 0)
        {
            meSound0.SetActive(true);
            meSound1.SetActive(true);
            myToggle3.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            meSound0.SetActive(false);
            meSound1.SetActive(false);
            myToggle3.GetComponent<Toggle>().isOn = false;
        }

        /*playShoot = false;*/
        shootButton = true;
        forHMA = 1;
        forHMDA = 1;
        switch(PlayerPrefs.GetInt("weapon"))
        {
            case 0:     yTimeShoot = 0.3;
            break;
            case 1:     yTimeShoot = 0.3;
            break;
            case 2:     yTimeShoot = 0.4;
            break;
            case 3:     yTimeShoot = 0.2;
            break;
            case 4:     yTimeShoot = 0.7;
            break;
        }

        for(int i = 0; i < PlayerPrefs.GetInt("levelPower03"); i++)
        {
            yTimeShoot -= yTimeShoot/8;
        }
        
        bulletType = 0;

        sideX = 0.03f;
        sideY = 0.05f;
        sideZ = 0.7f;
        doubleDShootStart = shootGO.transform.position.z;
        i = 1;
    }

    void Update()
    {   
        doubleDShootStart = shootGO.transform.position.z;
        if(shootButton)
        {
            image1.GetComponent<Image>().color = Color.white;
            image2.GetComponent<Image>().color = Color.gray;
        }
        else
        {
            image2.GetComponent<Image>().color = Color.white;
            image1.GetComponent<Image>().color = Color.gray;
        }

        if(boolBiggerBullet)
        {
            timerBiggerBullet += Time.deltaTime;
            if(timerBiggerBullet >= timeBiggerBullet)
            {
                print("Fase 2");
                timerBiggerBullet = 0;
                timeBiggerBullet = 0;
                boolBiggerBullet = false;
            }
        }
        else
        {
            sideX = 0.03f;
            sideY = 0.05f;
            sideZ = 0.7f;
        }


        evilChas = GameObject.Find("EVILCha");
        if(evilChas != null)
        {
            if(evilChas.transform.position.x > gameObject.transform.position.x - 25 || evilChas.transform.position.x < gameObject.transform.position.x + 25|| evilChas.transform.position.y < gameObject.transform.position.y + 25 || evilChas.transform.position.y > gameObject.transform.position.y - 25)
            {
//                Debug.Log(evilChas.transform.position.x);
                if(shootButton)
                {
                    if(shoot1)
                    {
                        
                        if(forHMDA == 1)
                        {
                            doubleDShootStart = shootGO.transform.position.z;
                            doubleDShootPlus  = 0;
                        }

                        if(forHMDA == 2)
                        {
                            doubleDShootStart = shootGO.transform.position.z - 1.5f;
                            doubleDShootPlus = 1f;
                        }

                        if(forHMDA == 3)
                        {
                            doubleDShootStart = shootGO.transform.position.z - 2f;
                            doubleDShootPlus = + 1f;
                        }

                        if(forHMDA == 4)
                        {
                            doubleDShootStart = shootGO.transform.position.z - 2.5f;
                            doubleDShootPlus = +1f;
                        }

                        doubleShoot = 0;
                        for(int k = 0; k < forHMDA; k++)
                        {
                            
//                            print("for 1 " + k + "  " + forHMDA + " douleCoor " + doubleDShootStart);

                            for(int i = 0; i < forHMA; i++)
                            {
//                                print("for 2 " + i );
                                if(PlayerPrefs.GetInt("potion3ACT") == 1)
                                {
                                    print("Fase 1");
                                    PlayerPrefs.SetInt("potion3ACT", 0);
                                    sideX *= 1.2f;
                                    sideY *= 1.2f;
                                    sideZ *= 1.2f;
                                    boolBiggerBullet = true;
                                    timeBiggerBullet += 10;
                                }

                                Vector3 position = new Vector3(shootGO.transform.position.x + doubleShoot, shootGO.transform.position.y, doubleDShootStart);
                                if(PlayerPrefs.GetInt("weapon") == 4 )
                                {
                                    GameObject newArrow = Instantiate(hammer, position, gameObject.transform.rotation) as GameObject;
                                    //newArrow.transform.localScale = new Vector3(sideX, sideY, sideZ);
                                }
                                else
                                {
                                    if(PlayerPrefs.GetInt("weapon") == 2 )
                                    {
                                        Quaternion abc = Quaternion.Euler(0, gameObject.transform.rotation.y ,0);

                                        GameObject newArrow = Instantiate(knife1, position, gameObject.transform.rotation) as GameObject;
                                    }
                                    else
                                    {
                                        GameObject newArrow = Instantiate(bullet, position, gameObject.transform.rotation) as GameObject;
                                        newArrow.transform.localScale = new Vector3(sideX, sideY, sideZ);
                                    }
                                }
                                
                                

                                if(behindArrows)
                                {
                                    Vector3 position1 = new Vector3(shootGOB.transform.position.x, shootGOB.transform.position.y, shootGOB.transform.position.z);
                                    GameObject newArrowB = Instantiate(bulletBehind, position1, rotateB.transform.rotation) as GameObject;
                                    newArrowB.transform.localScale = new Vector3(sideX, sideY, sideZ);
                                }
                                if(sideArrows)
                                {
                                    Vector3 position2 = new Vector3(shootGOS1.transform.position.x, shootGOS1.transform.position.y, shootGOS1.transform.position.z);
                                    GameObject newArrowS1 = Instantiate(bulletSide1, position2, rotateS1.transform.rotation) as GameObject;
                                    newArrowS1.transform.localScale = new Vector3(sideX, sideY, sideZ);

                                    Vector3 position3 = new Vector3(shootGOS2.transform.position.x, shootGOS2.transform.position.y, shootGOS2.transform.position.z);
                                    GameObject newArrowS2 = Instantiate(bulletSide2, position3, rotateS2.transform.rotation) as GameObject;
                                    newArrowS2.transform.localScale = new Vector3(sideX, sideY, sideZ);
                                }
                                
                                doubleShoot += 1.5f;
                                
                            }
                            doubleDShootStart += doubleDShootPlus;
                            doubleShoot = 0;

                            //doubleDShootStart = 0;
                        }
                        
                        
                        shoot1 = false;
                    }
                    doubleDShootStart = shootGO.transform.position.z;
                    timerShoot += Time.deltaTime;
                    if(timerShoot >= yTimeShoot)
                    {
                        timerShoot = 0;
                        shoot1 = true;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "addBulletDamage")
        bulletType++;
    }

    public GameObject image1, image2, image3;

    public void shootButton1()
    {
        shootButton = true;
        setBlock.button2 = false;
        setBlock.button3 = false;
        image3.SetActive(false);
        image2.SetActive(true);

        i = 1;
    }    
    public int i;


    public void stopArrow(bool playSBA)
    {
        if(playSBA)
        {
            playShoot = false;
            PlayerPrefs.SetInt("stopArrow", 0);
        }
        else
        {
            playShoot = true;
            PlayerPrefs.SetInt("stopArrow", 1);
        }
    }
    public void evilSound(bool playSB)
    {
        if(playSB)
        {
            soundMonsters = false;
            PlayerPrefs.SetInt("evilSound",0);
        }
        else
        {
            soundMonsters = true;
            PlayerPrefs.SetInt("evilSound",1);
        }
    }
    public GameObject music;
    public void ambientMusic(bool playSBM)
    {
        if(playSBM)
        {
            music.SetActive(true);
            PlayerPrefs.SetInt("ambientMusic",0);
        }
        else
        {
            music.SetActive(false);
            PlayerPrefs.SetInt("ambientMusic",1);
        }
    }
    public void meSound(bool playSBM)
    {
        if(playSBM)
        {
            meSound0.SetActive(true);
            meSound1.SetActive(true);
            PlayerPrefs.SetInt("meSound",0);
        }
        else
        {
            meSound0.SetActive(false);
            meSound1.SetActive(false);
            PlayerPrefs.SetInt("meSound",1);
        }
    }
}



                /*if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                    {
                        if(Input.GetTouch(0).position.y >= 125)
                        {
                            shoot = true;
                        }
                        
                        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                        if(Physics.Raycast(ray, out RaycastHit info))
                        {
                            Debug.Log(info.transform.tag);
                        }
                    }
                }*/
                //if(Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
                //{
                    //shoot = true;
                //}
                /*if(Input.touchCount <= 0)
                {
                    shoot = false;
                }
                evilCha == null || 
                */
