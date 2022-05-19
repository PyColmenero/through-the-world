using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetBlock : MonoBehaviour
{

    public GameObject prefab1;
    public ShootPC shootPC;
    public PlayerControler playerControler;
    public int amount = 20;
    float timer = 0;
    bool clicking;

    float setX, setZ;
    int countX, countZ;

    public bool button2, button3;

    float timerButton, timerButtonCS;
    bool pressingClick, setDeleteB;


    bool touchOnce;

    float timerH;
    void Start() 
    {
        image1.SetActive(true);
        image2.SetActive(false);
    }

    void Update()
    {

        if(button2)
        {
            if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                if(Input.mousePosition.y > Screen.height / 2.68f)
                {
                    print(Input.mousePosition.y);
                    InstantiateOnPosition(Input.mousePosition);
                }
            }
            /*
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began )
            {
                if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    
                }
            }

            if(Input.GetMouseButtonDown(0))
            {
                if (Input.mousePosition.y > 260)
                {
                    InstantiateOnPosition(Input.mousePosition);
                }
            }*/
        }

        if(button3)
        {
            if(Input.touchCount > 0/* && Input.GetTouch(0).phase == TouchPhase.Began*/)
            {
                delete = true;
                /*if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    if(Input.GetTouch(0).position.y > 260)
                    {
                        
                    }
                }*/
            }
            if (Input.GetMouseButtonDown(0))
            {
                delete = true;

            }

        }

        if(Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            if(delete)
            {
                DeleteOnPositionA(Input.mousePosition);
                timer += Time.deltaTime;
                if(timer >= 1f)
                {           
                    DeleteOnPosition(Input.mousePosition);
                    timer = 0; 
                }
            }
        }
        else
        {
            delete = false;
            timer = 0;
        }
        
    }

    bool delete;
    public BoxCollider barriadaA;

    void DeleteOnPosition(Vector3 mousePosD)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(mousePosD);
        if(Physics.Raycast(ray, out hit))
        {
            BoxCollider bc = hit.collider as BoxCollider;
            barriadaA = bc;
            if(bc != null)
            {
                if(bc.transform.tag == "barrier")
                {
                    if(bc.transform.position.x < playerControler.pControlerX + 20)
                    { 
                        Destroy(bc.gameObject);
                        bc.gameObject.transform.localScale = new Vector3(1.001f, 1, 1);
                    }
                }
                else
                {
                    timer = 0;
                    //bc.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }
    }

    void DeleteOnPositionA(Vector3 mousePosD)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(mousePosD);
        if(Physics.Raycast(ray, out hit))
        {
            BoxCollider bc = hit.collider as BoxCollider;
            barriadaA = bc;
            if(bc != null)
            {
                if(bc.transform.tag == "barrier")
                {
                    if(bc.transform.position.x < playerControler.pControlerX + 20)
                    { 
                        bc.gameObject.transform.localScale = new Vector3(1.001f, 1, 1);
                    }
                }
                else
                {
                    timer = 0;
                    //bc.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }
    }

    public GameObject barriada;
    float vectorXXWood, vectorXYWood, vectorXXCamera, vectorXYCamera, arcTangente, catetoX, catetoY;
    public float angA;

    void InstantiateOnPosition(Vector3 mousePos)
    {
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        if(Physics.Raycast(ray, out RaycastHit info))
        {
//            print(info.transform.tag);
            BoxCollider bc = info.collider as BoxCollider;
 //           print(bc.transform.tag);
            if (bc.transform.tag != "barrier" && bc.transform.tag != "Player" && bc.transform.tag != "wallR" && bc.transform.tag != "wallL")
            {
                
                if(info.collider.transform.position.x < playerControler.pControlerX + 20)
                {
                    
                    //REDONDEO
                    setX = info.point.x;
                    setZ = info.point.z;

                    countX = 0;
                    for(;setX > 0.5; setX--)
                    {
                        countX++;
                    }
                    
                    setX = info.point.x;
                    setX = setX - (setX - countX);

                    countZ = 0;
                    for(;setZ > 0.5; setZ--)
                    {
                        countZ++;
                    }
                    setZ = info.point.z;
                    setZ = setZ - (setZ - countZ);

                            

                            vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
                            vectorXYCamera = gameObject.GetComponent<Transform>().position.z;

                            vectorXXWood = setX;
                            vectorXYWood = setZ;

                            catetoX = vectorXXCamera - vectorXXWood;
                            catetoY = vectorXYCamera - vectorXYWood;

                            if (catetoX < 0)
                            {
                                catetoX *= -1;
                            }
                            if (catetoY < 0)
                            {
                                catetoY *= -1;
                            }

                            arcTangente = (Mathf.Atan(catetoY / catetoX));
                            
                            arcTangente = (arcTangente * 180) / Mathf.PI;
                            
                            angA = arcTangente;

                            if (angA < 0)
                            {
                                angA *= -1;
                            }

                            angA = 90 - angA;

                            if (vectorXXCamera > vectorXXWood)
                            {
                                if(vectorXYCamera < vectorXYWood)
                                {
                                    angA = angA * (-1);

                                }
                            }
                            if (vectorXXCamera < vectorXXWood)
                            {
                                if (vectorXYCamera > vectorXYWood)
                                {
                                    angA = (angA * -1) + 180;
                                }
                            }
                            if (vectorXXCamera > vectorXXWood)
                            {
                                if (vectorXYCamera > vectorXYWood)
                                {
                                    angA = (angA) - 180;
                                }
                            }

                    angA += 90;
                    barriada.transform.eulerAngles = new Vector3(0,angA,0);

                    //INSTANCIAR
                    Vector3 instantaiatePoint = new Vector3(setX, info.point.y + 1.5f, setZ);
                    GameObject newGO = Instantiate(prefab1, instantaiatePoint, barriada.transform.rotation);
                    amount--;
                    Debug.Log("FASE5");
                }
            }
        }
    }
                        
    


        /*public void shootButton2()
        {
            shootPC.shootButton = false;
            button1 = true;
            button2 = false;
        }  */
        public GameObject image1, image2;
        public void shootButton3()
        {
            shootPC.shootButton = false;
            if(shootPC.i == 1)
            {
                image1.SetActive(true);
                image2.SetActive(false);
                button2 = true;
            }
            else
            {
                if(i == 0)
                {
                    button3 = false;
                    button2 = true;
                    i = 1;
                    image1.SetActive(true);
                    image2.SetActive(false);
                }   
                else
                {
                    button3 = true;
                    button2 = false;
                    i = 0;
                    image2.SetActive(true);
                    image1.SetActive(false);
                }
            }

            shootPC.i = 0;
        }  
        int i = 1;
}


/* }
            else
            {
                if(Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
                {
                    touchOnce = true;
                    Debug.Log("touch begun1" + Input.GetTouch(0).position);
                }
                else
                {
                    touchOnce = false;
                }
            }*/
            
            /*if(computerVSAndroid)
            {
                if(Input.touchCount <= 0)
                {
                    touchOnce = false;
                }
            }*/