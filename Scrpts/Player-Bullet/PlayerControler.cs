using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public AudioSource walk;
    float timer;
    public float pControlerX, pControlerY, pControlerZ, pControlerXA, pControlerYA, pControlerZA;
    bool canJump, buttonJ;

    public int fJump;

    float x, xCS, xStart, countXMax;
    int countX;
    bool backWards;

    public GameObject Animator;

    protected Joystick joystick;
    protected Joybutton joybutton;

    bool leftCA, rightCA, buttonCA;

    float timerA1, timerA2;
    public GameObject camera;
    int j = 0, e = 0, h = 0, t = 0, s = 0, v = 0;

    float setX, setZ, runX, runZ, runXX, runZZ, countXX, countZ, timerRun;
    float timerAni;

    float walkTime;

    public float speedJoyS;
   
    void Start()
    {
        speedJoyS = 18;

        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

        

        x = gameObject.transform.position.x;
        xCS = x;
        xStart = x;

        pControlerX = gameObject.transform.position.x;
        pControlerY = gameObject.GetComponent<Transform>().position.y;
        pControlerZ = gameObject.GetComponent<Transform>().position.z;
        pControlerXA = gameObject.GetComponent<Transform>().rotation.x;
        pControlerYA = gameObject.GetComponent<Transform>().rotation.y;
        pControlerZA = gameObject.GetComponent<Transform>().rotation.z;

        runXX = pControlerX;
        //runY = pControlerY;
        runZZ = pControlerZ;
    }

    void Update()
    {

        //ASIGNACIONES
         pControlerX = gameObject.transform.position.x;
        pControlerY = gameObject.GetComponent<Transform>().position.y;
        pControlerZ = gameObject.GetComponent<Transform>().position.z;
         pControlerXA = gameObject.GetComponent<Transform>().rotation.x;
        pControlerYA = gameObject.GetComponent<Transform>().rotation.y;
        pControlerZA = gameObject.GetComponent<Transform>().rotation.z;

        //RUN
        setX = pControlerX;
        setZ = pControlerZ;

        countXX = 0;
        for(;setX > 0; setX--)
        {
            countXX++;
        }
        
        setX = pControlerX;
        setX = setX - (setX - countXX);

        countZ = 0;
        for(;setZ > 0.5; setZ--)
        {
            countZ++;
        }
        setZ = pControlerZ;
        setZ = setZ - (setZ - countZ);
        //Debug.Log(setX + " sets " + setZ);


        
        

        countXX = 0;
        for(;runX > 0; runX--)
        {
            countXX++;
        }
        
        runX = pControlerX;
        runX = runX - (runX - countXX);

        countZ = 0;
        for(;runZ > 0.5; runZ--)
        {
            countZ++;
        }
        runZ = pControlerZ;
        runZ = runZ - (runZ - countZ);
        //Debug.Log(runX + " runs " + runZ);


        if(runX != setX)
        {   

            walkTime+= Time.deltaTime;
            if(walkTime>=0.2)
            {
                walk.Play();
                walkTime = 0;
            }

            runX = pControlerX;
            Animator.GetComponent<Animator>().SetBool("Run", true);
            timerAni = 0;
        }

        if(runZ != setZ)
        {
            walkTime+= Time.deltaTime;
            if(walkTime>=0.2)
            {
                walk.Play();
                walkTime = 0;
            }
           

            runZ = pControlerZ;
            Animator.GetComponent<Animator>().SetBool("Run", true);
            timerAni = 0;
        }

        //NOT MOVING
        if(runZ == setZ && runX == setX)
        {
            timerAni += Time.deltaTime;
            if(timerAni >= 0.3)
            {
                Animator.GetComponent<Animator>().SetBool("Run", false);
            }
        }

        
        
        


        //BACKWARDS
        x = gameObject.transform.position.x;
        
        if(gameObject.transform.position.x < countXMax-20)
        {
            backWards = false;
        }

        if(x > xCS)
        {
            countXMax = x-xStart;
            countX++;
            xCS = x;
            backWards = true;
        }

        //HEALTH
        

        //CAMERA ANIMATION
        if(buttonCA)
        {
            if(pControlerZ <= 6.5f)
            {   
                if(j == 0)
                {
                    camera.GetComponent<Animator>().SetBool("RightN", true);
                    j = 1;
                    rightCA = true;
                }
                Debug.Log("FASE1");
            }
            else
            {
                if(rightCA)
                {
                    Debug.Log("FASE2");
                    if(e == 0)
                    {
                        camera.GetComponent<Animator>().SetBool("RightN", false);
                        e = 1;
                    }
                    timerA1 += Time.deltaTime;
                    if(timerA1 >= 0.3)
                    {
                        if(s == 0)
                        {
                            camera.GetComponent<Animator>().SetBool("IdleR", true);
                            s = 1;
                        }
                        
                        if(timerA1 >= 0.6)
                        {
                            camera.GetComponent<Animator>().SetBool("IdleR", false);
                            rightCA = false;
                            timerA1 = 0;
                            j = 0;
                            s = 0;
                            e = 0;
                        }
                    }
                }
                
            }

            if(pControlerZ >= 13.5f)
            {
                if(t == 0)
                {
                    camera.GetComponent<Animator>().SetBool("LeftN", true);
                    leftCA = true;
                    t = 1;
                }
            }
            else
            {
                if(leftCA)
                {
                    if(v == 0)
                    {
                        camera.GetComponent<Animator>().SetBool("LeftN", false);
                        v = 1;
                    }

                    timerA2 += Time.deltaTime;
                    if(timerA2 >= 0.3)
                    {
                        if(h == 0)
                        {
                            camera.GetComponent<Animator>().SetBool("IdleL", true);
                            h = 1;
                        }
                        if(timerA2 >= 0.6)
                        {
                            camera.GetComponent<Animator>().SetBool("IdleL", false);
                            timerA2 = 0;
                            leftCA = false;
                            t = 0;
                            v = 0;
                            h = 0;
                        }
                    }
                }
            }
        }
        else
        {
            camera.GetComponent<Animator>().SetBool("IdleL", false);
        }

        //CONTROLS
       
        timer += Time.deltaTime;

        if(canJump == false)
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3(joystick.Vertical * (speedJoyS - (speedJoyS/4.5f)), rigidbody.velocity.y, joystick.Horizontal * ((speedJoyS - (speedJoyS/4.5f)) * -1));
        }
        else
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3(joystick.Vertical * speedJoyS, rigidbody.velocity.y, joystick.Horizontal * ((speedJoyS) * -1));
        }


        if(Input.GetKey("w"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(700f , 0, 0));  
        }

        if(Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 700f));
            //transform.Rotate(0, 1, 0, Space.Self);
        }

        if(Input.GetKey("s"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-700f, 0, 0));            
        }

        if(Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -700f));
        }

        
        if((Input.GetKeyDown(KeyCode.Space) || buttonJ) && canJump)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, fJump, 0));
            canJump = false;
        }

        if(jump)
        {
//            print("FASE1");
            timerJ += Time.deltaTime;
            if(timerJ >= 0.8f)
            {
   //             print("FASE2");
                Animator.GetComponent<Animator>().SetBool("Jump", false);
                timerJ = 0;
                jump = false;
            }
        }
    }
    


        //CAN JUMP
        private void OnCollisionEnter(Collision collision) 
        {
            //Debug.Log("1");
            if (collision.transform.tag == "ground")
            {
                canJump = true;
            }
            if (collision.transform.tag == "groundStair")
            {
                canJump = true;
            }
            if (collision.transform.tag == "blockY")
            {
                canJump = true;
            }
            if (collision.transform.tag == "decor")
            {
                canJump = true;
            }
        }

        private void OnTriggerEnter(Collider other) 
        {

        }
        bool jump;
        float timerJ;

        //JumpButtons
        public void jumpB()
        {
//            print("FASE3");
            jump = true;
            buttonJ = true;
            Animator.GetComponent<Animator>().SetBool("Jump", true);
        }
        public void nJumpB()
        {
//            print("FASE4");
            buttonJ = false;
            //gameObject.GetComponent<Animator>().SetBool("Jump", false);
        }

        public void buttonCAON()
        {
            buttonCA = true;
        }
        public void buttonCAOFF()
        {
            buttonCA = false;
        }
}   
