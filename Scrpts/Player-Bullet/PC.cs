/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityStandartAssets.CrossPlatformInput;

public class PlayerControler : MonoBehaviour
{

    bool canJump;
    int jumpOn = 0;
    int vectorX;
    float timer;
    public float vectorXXCamera;
    public float vectorXYCamera;
    public float vectorXXWood;
    public float vectorXYWood;
    float catetoX;
    float catetoY;
    float hipotenusa;
    float angA;
    float arcTangente;
    int activeTrigo = 0;
    bool inPutQ = false;
    int inPutQInt = 0;
    float timer2;
    int sSpeedX = 1;

    int fuerzaF3 = -650;
    int fuerzaF4 = 650;
    int fuerzaJ = 350;

    int subirSpeed = 0;


    bool buttonL = false;
    bool buttonR = false;
    bool buttonJ = false;


        public DestroyWood destroyWood;
        public ScoreManager scoreManager;
   

    // Update is called once per frame
    void Update()
    {
        //SUBIR SPEED 
        
        if(subirSpeed >= sSpeedX)
        {
            subirSpeed = 0;
            fuerzaF3 -= 100;
            fuerzaF4 += 100;
            fuerzaJ += 50;
            sSpeedX++;
            Debug.Log("fuerza3/4 = " + fuerzaF3 + " , " + fuerzaF4 + " , " + fuerzaJ);
        }
        subirSpeed = scoreManager.score;
        
        //BUTTON Q
        activeTrigo = scoreManager.score;

        if(Input.GetKeyDown("q"))
            {
                activeTrigo = scoreManager.score;
                Debug.Log("activeT: " + activeTrigo);
                if(activeTrigo >= 1)
                {
                  inPutQ = true;
                   inPutQInt++;
                   
                   if(inPutQInt >= 2)
                   {
                        Debug.Log("iPInt: " + inPutQInt);
                        inPutQInt = 0;
                        inPutQ = false;
                        
                        //scoreManager.score = 1;
                        scoreManager.RaiseScore(-1);
                   }
            }

        }

        //TRIGONOMETRIA
        if (inPutQ== true);
        { 
            if(activeTrigo >= 1)
            {
            vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
            vectorXYCamera = gameObject.GetComponent<Transform>().position.y;

            //TRIGONOMETRIA
            vectorXXWood = destroyWood.vectorX ;
            vectorXYWood = destroyWood.vectorY ;

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

            if (vectorXXCamera < vectorXXWood)
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
                    angA = (angA) -180;
                }
            }
            if (vectorXXCamera > vectorXXWood)
            {
                if (vectorXYCamera > vectorXYWood)
                {
                    angA = (angA * -1) + 180;
                }
            }


            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, angA);


            //transform.RotateAround(transform.position, Vector3.back, angA)
            }
        }
        
        //Quaternarion 0
        if(!Input.GetKey("q"))
        {
            if(inPutQ == false){
            gameObject.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);}
            
        }
        
        timer2 += Time.deltaTime;
        

        if(timer2 >= 1)
        {

        {/*ANDAR
        
            if (Input.GetKey("a"))
                {//Mover en Suelo
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerzaF1 * Time.deltaTime, 0));
                gameObject.GetComponent<Animator>().SetBool("Sprint", false);
                gameObject.GetComponent<Animator>().SetBool("moving", true);

                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                if (Input.GetKey("d"))
                {
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerzaF2 * Time.deltaTime, 0));
                gameObject.GetComponent<Animator>().SetBool("Sprint", false);
                gameObject.GetComponent<Animator>().SetBool("moving", true);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }

                if (!Input.GetKey("a") && !Input.GetKey("d"))
                {
                    gameObject.GetComponent<Animator>().SetBool("moving", false);
                    //gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
            
        }
        
        //CORRER
        {
            
                if (buttonL || Input.GetKey("a"))
                {//Mover en Suelo
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerzaF3 * Time.deltaTime, 0));
                    
                    gameObject.GetComponent<Animator>().SetBool("Sprint", true);

                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                if (buttonR || Input.GetKey("d"))
                {
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerzaF4 * Time.deltaTime, 0));
                    
                    gameObject.GetComponent<Animator>().SetBool("Sprint", true);
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                    
                }

                /* if (!Input.GetKey("a") && !Input.GetKey("d"))
                {
                    gameObject.GetComponent<Animator>().SetBool("Sprint", false);
                    
                }
            
        }
        //SALTAR
        if (buttonJ  || Input.GetKey("w") && canJump )
        {
            gameObject.GetComponent<Animator>().SetBool("Jump", true);
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 350f));
            jumpOn++;
        }

        if(!Input.GetKey("a") && !Input.GetKey("d"))
        {
            gameObject.GetComponent<Animator>().SetBool("Sprint", false);
        }
            
        }

        timer += Time.deltaTime;
        if (jumpOn >= 1) 
        {
            if (timer >= 1)
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
                timer = 0;
                jumpOn = 0;
            }
            
        }


        //CODIGO ERROR A

        vectorXXCamera = gameObject.GetComponent<Transform>().position.x;
        vectorXYCamera = gameObject.GetComponent<Transform>().position.y;

        //CODIGO ERROR A
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
            canJump = true;
            Debug.Log("CAN JUMP TRUE COLLISION");
            gameObject.GetComponent<Animator>().SetBool("Jump", false);
           
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
            canJump = true;
            Debug.Log("CAN JUMP TRUE TRIGGER");
            gameObject.GetComponent<Animator>().SetBool("Jump", false);
        }
    }

    //BUTTONS
        public void forceR()
        {
            buttonL = true;
        }
        public void nForceR()
        {
            buttonL = false;
                gameObject.GetComponent<Animator>().SetBool("Sprint", false);
        }
                
    public void forceL()
        {
            buttonR = true;
        }
        public void nForceL()
        {
            buttonR = false;
            gameObject.GetComponent<Animator>().SetBool("Sprint", false);
        }

        
        public void jumpB()
        {
            buttonJ = true;
        }
        public void nJumpB()
        {
            buttonJ = false;
            gameObject.GetComponent<Animator>().SetBool("Jump", false);
        }
        

        //PAUSE
        int pause = 0;
        public void pauseG(){
            Time.timeScale = 0;
            pause++;
            if(pause >= 2)
            { 
                pause = 0;
                Time.timeScale = 1;
            }
        }
    }*/
