using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public GameObject camera;
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    int scene = 0;
    float timerR, timerL;
    bool backR, backL;
    private float dragDistance;  //minimum distance for a swipe to be registered

    public float xCS, x;
    public float move;
    public bool first;
    public float baseX;
    public int baseXX, stopFase;

    public int whereAmI;

    public int i = 9;

    public float speed = 10;
    float step;
    public Vector3 instantaiatePoint;
    public int coolDown;
    public int speedSwipeX, speedSwipeY;
    public float speedXS;
    public float timerS;
    public VerticalSwipe verticalSwipe;
    public bool hSwipe;

    public GameObject canvas00, canvas01, canvas02, canvas03, canvas04;
 
    void Start()
    {
        dragDistance = Screen.height * 10 / 100; //dragDistance is 15% height of the screen
        camera.transform.position = new Vector3(0, camera.transform.position.y, -95);
        coolDown = 60;
        speedXS = 3;
    }

    public float firstClick;
    public bool rightSpeed, leftSpeed;
    float timerSpeed;
    float timerHS;
    
    public float h = 0;
    public float ammountRec;
    public bool getOut;

    void Update()
    {   
        step =  speed * Time.deltaTime;
        h = Input.mousePosition.x;
        switch(whereAmI)
        {
            case -4:
                canvas00.SetActive(true);
                canvas01.SetActive(true);
                canvas02.SetActive(false);
                canvas03.SetActive(false);
                canvas04.SetActive(false);
            break;
            case -2:
                canvas00.SetActive(true);
                canvas01.SetActive(true);
                canvas02.SetActive(true);
                canvas03.SetActive(false);
                canvas04.SetActive(false);
            break;
            case 0:
                canvas00.SetActive(false);
                canvas01.SetActive(true);
                canvas02.SetActive(true);
                canvas03.SetActive(true);
                canvas04.SetActive(false);
            break;
            case 2:
                canvas00.SetActive(false);
                canvas01.SetActive(false);
                canvas02.SetActive(true);
                canvas03.SetActive(true);
                canvas04.SetActive(true);
            break;
            case 4:
                canvas00.SetActive(false);
                canvas01.SetActive(false);
                canvas02.SetActive(false);
                canvas03.SetActive(true);
                canvas04.SetActive(true);
            break;
        }
        if(Input.GetMouseButton(0))
        {

        }
        else
        {
            getOut = true;
        }

        if(Input.GetMouseButton(0) && camera.transform.position.x <= 108 && camera.transform.position.x > -112 && getOut)
        {
            if(ammountRec > 45)
            {
                getOut = false;
            }
            else if(ammountRec < -45)
            {
                getOut = false;
            }
            //print(Input.mousePosition.x);
            timerHS = 0;

            if((whereAmI == 2 || whereAmI == -4) && verticalSwipe.vSwipe == true)
            {

            }
            else
            {
                
                timerS += Time.deltaTime;
                x = Input.mousePosition.x;
                if(first)
                {
                    first = false;
                    xCS = x;
                    firstClick = Input.mousePosition.x;
                }
                
                if(x >= xCS + coolDown)
                {
                    hSwipe = true;
                    if(timerS < 0.2f && Input.mousePosition.x > firstClick + Screen.width/10)
                    {
                        leftSpeed = true;
                    }
                    coolDown = 1;
                    move += speedXS    ;
                    xCS = x;
                    speedSwipeX++;
                    
                    speedSwipeY = 0;
                }
                if(x <= xCS - coolDown)
                {
                    hSwipe = true;

                    if(timerS < 0.2f && Input.mousePosition.x < firstClick - 60)
                    {
                        rightSpeed = true;
                    }
                    coolDown = 1;
                    xCS = x;
                    move-= speedXS;
                    speedSwipeY++;
                    speedSwipeX = 0;

                }
                move /= 5;
                ammountRec += move;
                
                camera.transform.position = new Vector3(camera.transform.position.x - move, camera.transform.position.y, -95);
                stopFase = 0;

            }
        }
        else
        { // -111.5 -105.5  -9.5     48 51 55      -7 0  +7     -49 -42 -54       97.5  102.5  111.5
            ammountRec = 0;
            timerHS += Time.deltaTime;
            if(timerHS >= 0.2f)
            {
                hSwipe = false;
            }


            timerS = 0;
            coolDown = 60;
            speedXS = 4;
            speedSwipeX = 0;
            speedSwipeY = 0;
            move = 0;
            xCS = x;
            first = true;
           
            if(camera.transform.position.x >= 102f && camera.transform.position.x <= 104f/* && baseX == 0*/)
            {

                i = -1;
                
                camera.transform.position = new Vector3(103, camera.transform.position.y, -95);
            }
            if(camera.transform.position.x >= 50f && camera.transform.position.x <= 52f/* && baseX == 0*/)
            {

                i = -1;
                
                camera.transform.position = new Vector3(51, camera.transform.position.y, -95);
            }
            if(camera.transform.position.x >= -1f && camera.transform.position.x <= 1f && baseX == 0)
            {

                i = 0;
                
                camera.transform.position = new Vector3(-0.5f, camera.transform.position.y, -95);
            }

            if(camera.transform.position.x <= -48f && camera.transform.position.x >= -50f/* && baseX == 0*/)
            {

                i = 1;
                
                camera.transform.position = new Vector3(-49f, camera.transform.position.y, -95);
            }
            
            if(camera.transform.position.x <= -104f && camera.transform.position.x >= -107f/* && baseX == 0*/)
            {

                i = 1;
                
                camera.transform.position = new Vector3(-105f, camera.transform.position.y, -95);
            }


            if(rightSpeed == false && leftSpeed == false)
            {
                if(camera.transform.position.x >= -120f && camera.transform.position.x <= -99.5f /*&& baseX == 0*/)
                {
                    whereAmI = -4;
                    baseXX = -2;
                    stopFase = 1;

                        speed = 100;
                        instantaiatePoint.x = -105.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);

                }

                if(camera.transform.position.x > -99.5f && camera.transform.position.x <= -54f/* && baseX == 0*/)
                {
                    whereAmI = -3;
                    if(baseXX == -1)
                    {
                        speed = 150;
                        instantaiatePoint.x = -105.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    else
                    {
                        speed = 150;
                        instantaiatePoint.x = -49f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    stopFase = 1;
                }

                if(camera.transform.position.x >= -54f && camera.transform.position.x <= -41f /*&& baseX == 0*/)
                {
                    baseXX = -1;
                    whereAmI =-2;
                    speed = 100;
                        instantaiatePoint.x =    -49f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                }

                if(camera.transform.position.x > -41f && camera.transform.position.x <= -7f/* && baseX == 0*/)
                {
                    whereAmI = -1;
                    if(baseXX == -1)
                    {
                        speed = 150;
                        instantaiatePoint.x =       -0.5f;
                        instantaiatePoint.y =   450.3f;
                        instantaiatePoint.z =       -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    else
                    {
                        speed = 150;
                        instantaiatePoint.x =    -49f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    stopFase = 1;
                }

                if(camera.transform.position.x <= 7f && camera.transform.position.x >= -7f/* && baseX == 0*/)
                {
                    whereAmI = 0;
                    baseXX = 0;
                    stopFase = 1;
                    speed = 100;
                        instantaiatePoint.x =     -0.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                }

                if(camera.transform.position.x <= 47f && camera.transform.position.x >= 7f/* && baseX == 0*/)
                {
                    whereAmI = 1;
                    if(baseXX == 1)
                    {
                        speed = 100;
                        instantaiatePoint.x = -0.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    else
                    {
                        speed = 100;
                        instantaiatePoint.x = 51f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    stopFase = 1;
                }

                if(camera.transform.position.x >= 47f && camera.transform.position.x <= 60f/* && baseX == 0*/)
                {
                    whereAmI = 2;
                    baseXX = 1;
                    stopFase = 1;
                    speed = 100;
                        instantaiatePoint.x =     51f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                }

                if(camera.transform.position.x > 60f && camera.transform.position.x <= 97.5f/* && baseX == 0*/)
                {
                    whereAmI = 3;
                    if(baseXX == 2)
                    {
                        speed = 100;
                        instantaiatePoint.x =      51;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    else
                    {
                        speed = 100;
                        instantaiatePoint.x =  102.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =     -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                    }
                    stopFase = 1;
                }

                if(camera.transform.position.x >= 97.5f && camera.transform.position.x <= 115f/* && baseX == 0*/)
                {
                    whereAmI = 4;
                    baseXX = 2;
                    stopFase = 1;
                    speed = 100;
                        instantaiatePoint.x = 102.5f;
                        instantaiatePoint.y =  450.3f;
                        instantaiatePoint.z =    -95;
                        gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                }

                // -111.5 -105.5  -9.5     48 51 55      -7 0  +7     -49 -42 -54       97.5  102.5  111.5

            } 
            else
            {
                timerSpeed += Time.deltaTime;
                if(timerSpeed >= 0.5f)
                {
                    timerSpeed = 0;
                    rightSpeed = false;
                    leftSpeed = false;
                }

                if(rightSpeed)
                {
                    switch(whereAmI)
                    {
                        case -4:
                            speed = 150;
                            instantaiatePoint.x =    -49f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case -2:
                            speed = 150;
                            instantaiatePoint.x =    -0.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 0:
                            speed = 150;
                            instantaiatePoint.x =    51;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 2:
                            speed = 150;
                            instantaiatePoint.x =    102.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 4:
                            speed = 1;
                            instantaiatePoint.x =  155.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                    }
                }
                if(leftSpeed)
                {
                    switch(whereAmI)
                    {
                        case -4:
                            speed = 1;
                            instantaiatePoint.x =  -155.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case -2:
                            speed = 150;
                            instantaiatePoint.x =  -105.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 0:
                            speed = 150;
                            instantaiatePoint.x =    -49f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 2:
                            speed = 150;
                            instantaiatePoint.x =    -0.5f;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                        case 4:
                            speed = 150;
                            instantaiatePoint.x =      51;
                            instantaiatePoint.y =  450.3f;
                            instantaiatePoint.z =     -95;
                            gameObject.transform.position = Vector3.MoveTowards(camera.transform.position, instantaiatePoint, step);
                        break;
                    }
                }
            }
        }
    }
}




        /* 
        if(backR)
        {
            timerR += Time.deltaTime;
            if(timerR >= 0.3f)
            {
                gameObject.GetComponent<Animator>().SetBool("LB", true);
                
            }
            if(timerR >= 0.4f)
            {
                gameObject.GetComponent<Animator>().SetBool("LB", false);
                timerR = 0;
                backR  = false;
            }
        }
        if(backL)
        {
            timerL += Time.deltaTime;
            if(timerL >= 0.3f)
            {
                gameObject.GetComponent<Animator>().SetBool("RB", true);
            }
            if(timerL >= 0.4f)
            {
                gameObject.GetComponent<Animator>().SetBool("RB", false);
                timerL = 0;
                backL  = false;
            }
        }


        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0); 
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lp = touch.position;  
 
                
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   
                        if ((lp.x > fp.x))  
                        {   //Right swipe
                            switch(scene)
                            {
                                case -1: scene = -1;
                                break;
                                case 0: scene = -1;
                                break;
                                case 1: scene = 0;
                                break;
                            }

                            switch(scene)
                            {
                                case 1: gameObject.GetComponent<Animator>().SetBool("Left", false);
                                gameObject.GetComponent<Animator>().SetBool("Right", false);
                                         scene = 0;
                                         backR = true;
                                         break;
                                case 0:  gameObject.GetComponent<Animator>().SetBool("Right", true);
                                         scene = -1;
                                         break;
                            }

                            Debug.Log("Left Swipe: " + scene);
                        }
                        else
                        {   //Left swipe
                            switch(scene)
                            {
                                case -1: scene = 0;
                                break;
                                case 0: scene = 1;
                                break;
                                case 1: scene = 1;
                                break;
                            }

                            switch(scene)
                            {
                                case -1: gameObject.GetComponent<Animator>().SetBool("Right", false);
                                gameObject.GetComponent<Animator>().SetBool("Left", false);
                                         scene = 0;
                                         backL = true;
                                         break;
                                case 0:  gameObject.GetComponent<Animator>().SetBool("Left", true);
                                         scene = 1;
                                         break;
                            }

                            Debug.Log("Right Swipe: " + scene);
                        }
                    }
                    else
                    { 
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe

                            Debug.Log("Up Swipe");
                        }
                        else
                        {   //Down swipe


                            Debug.Log("Down Swipe");
                        }
                    }
                }
                else
                {   //Tap
                    Debug.Log("Tap");
                }
            }*/
        
    

