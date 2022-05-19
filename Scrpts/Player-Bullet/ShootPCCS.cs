/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ShootPCCS : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public PlayerControler playerControler;
    public SetBlock setBlock;
    public bool shootButton = false;
    bool shoot, shoot1 = true;
    float timerShoot;
    int bulletType = 0;
    public double yTimeShoot = 0.1;

    void Start()
    {
        shootButton = true;
    }

    void Update()
    {
        if(shootButton)
        {
            
            

            
                if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                    {
                        shoot = true;
                        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                        if(Physics.Raycast(ray, out RaycastHit info))
                        {
                            Debug.Log(info.transform.tag);
                        }
                    }
                }
            

                //if(Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
                //{
                    //shoot = true;
                //}
            
            
           
                if(Input.touchCount <= 0)
                {
                    shoot = false;
                }
            

            


            if(shoot)
            {
                if(shoot1)
                {
                    if(bulletType == 0)
                    {
                        Vector3 position = new Vector3(playerControler.pControlerX + 1f, playerControler.pControlerY, playerControler.pControlerZ - 0.65f);
                        Quaternion rotation = new Quaternion(0,5,0,5);
                        Instantiate(bullet, position, rotation);
                    }
                    if(bulletType == 1)
                    {
                        Vector3 position = new Vector3(playerControler.pControlerX + 1f, playerControler.pControlerY, playerControler.pControlerZ - 0.65f);
                        Quaternion rotation = new Quaternion(0,5,0,5);
                        Instantiate(bullet1, position, rotation);
                    }
                    if(bulletType == 2)
                    {
                        Vector3 position = new Vector3(playerControler.pControlerX + 1f, playerControler.pControlerY, playerControler.pControlerZ - 0.65f);
                        Quaternion rotation = new Quaternion(0,5,0,5);
                        Instantiate(bullet2, position, rotation);
                    }
                    if(bulletType == 3)
                    {
                        Vector3 position = new Vector3(playerControler.pControlerX + 1f, playerControler.pControlerY, playerControler.pControlerZ - 0.65f);
                        Quaternion rotation = new Quaternion(0,5,0,5);
                        Instantiate(bullet3, position, rotation);
                    }
                    if(bulletType == 4)
                    {
                        Vector3 position = new Vector3(playerControler.pControlerX + 1f, playerControler.pControlerY, playerControler.pControlerZ - 0.65f);
                        Quaternion rotation = new Quaternion(0,5,0,5);
                        Instantiate(bullet4, position, rotation);
                    }
                
                    shoot1 = false;
                }
                timerShoot += Time.deltaTime;
                if(timerShoot >= yTimeShoot)
                {
                    timerShoot = 0;
                    shoot1 = true;
                    shoot = false;
                }
            }   
        }

    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "addBulletDamage")
        bulletType++;
    }

    public void shootButton1()
    {
        shootButton = true;
        setBlock.button1 = false;
        setBlock.button2 = false;
    }    
}
*/