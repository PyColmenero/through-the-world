using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_04 : MonoBehaviour
{


   public float speed;
    public GameObject player;
    public Vector3 instantaiatePoint;

    float evilX;

    //IA
    public double timerR = 1;
    int xy = 1;
    float timer1;
    float timer;
    double timerC;

    bool rango, rango1 = true, rango2 = true;

    int detectClick = 0;
    bool toX, jump;
    public int faseIA = 0;
    public bool ostia;

    void Start()
    {
        faseIA = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.Find("Player------------------------------------");
        evilX = gameObject.transform.position.x;
        instantaiatePoint = player.transform.position;


                /*if(rango1 && rango2 && jump == false)
                {
                    xy = Random.Range(1,5);
                    if(xy == 2)
                    {

                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 150));
                        
                    }
                    if(xy == 3)
                    {

                            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -150));
                        
                    }
                    if(xy == 4)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(150f, 0, 0));

                    }
                    if(xy == 1)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-150f, 0, 0));
                    }
                }*/

                if(player.gameObject.transform.position.x < evilX + 35 && player.gameObject.transform.position.x > evilX - 35 && rango == false)
                {
                    rango = true;
                    
                }

               
                if(rango)
                {
                    float step =  speed * Time.deltaTime;
                    switch(faseIA)
                    {
                        case 0:
                            instantaiatePoint.x = player.gameObject.transform.position.x + 5;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z + 0;
                        break;

                        case 1:
                            instantaiatePoint.x = player.gameObject.transform.position.x + 4;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z - 4;
                        break;

                        case 2:
                            instantaiatePoint.x = player.gameObject.transform.position.x + 0;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z - 5;
                        break;

                        case 3:
                            instantaiatePoint.x = player.gameObject.transform.position.x - 4;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z - 4;
                        break;

                        case 4:
                            instantaiatePoint.x = player.gameObject.transform.position.x - 5;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z + 0;
                        break;

                        case 5:
                            instantaiatePoint.x = player.gameObject.transform.position.x - 4;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z + 4;
                        break;

                        case 6:
                            instantaiatePoint.x = player.gameObject.transform.position.x + 0;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z + 5;
                        break;

                        case 7:
                            instantaiatePoint.x = player.gameObject.transform.position.x + 4;
                            instantaiatePoint.y = player.gameObject.transform.position.y + 5;
                            instantaiatePoint.z = player.gameObject.transform.position.z + 4;
                        break;
                    }
                    
                    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, instantaiatePoint, step);
                    if(gameObject.transform.position.x == player.gameObject.transform.position.x + 0 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z - 5)
                    {
                        faseIA = 4;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x - 4 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z + 4)
                    {
                        faseIA = 7;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x - 5 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z + 0)
                    {
                        faseIA = 6;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x + 4 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z - 4)
                    {
                        faseIA = 3;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x + 0 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z + 5)
                    {
                        faseIA = 0;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x + 4 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z + 4)
                    {
                        faseIA = 1;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x + 5 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z + 0) 
                    {
                        faseIA = 2;
                        ostia = true;
                    }
                    else if(gameObject.transform.position.x == player.gameObject.transform.position.x - 4 && gameObject.transform.position.y == player.gameObject.transform.position.y + 5 && gameObject.transform.position.z == player.gameObject.transform.position.z - 4) 
                    {
                        faseIA = 5;
                        ostia = true;
                    }
                    else
                    {
                        ostia = false;
                    }
                    

                }

            timerR = Random.Range(11,21);
            timerR /= 10;
            timer1 = 0;
   

        
    }


        private void OnTriggerEnter(Collider collision) 
    {
        if(collision.transform.tag == "bullet")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3( 10f, 0, 0));
        }

        if(collision.transform.tag == "groundStair")
        {
            jump = true;
            if(toX)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-50, 70, 0));
            }
            else
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(50, 70, 0));
            }
        }
        else
        {
            jump = false;
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.transform.tag == "player1")
        {
            detectClick = Random.Range(0,5);
            if(detectClick <= 2)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -100f));
            }
            else
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100f));
            }
        }
        if(collision.transform.tag == "wallR")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100f));
            Debug.Log("Archer Wall1");
        }
        if(collision.transform.tag == "wallL")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -100f));
            Debug.Log("Archer Wall2");
        }
    }

}


