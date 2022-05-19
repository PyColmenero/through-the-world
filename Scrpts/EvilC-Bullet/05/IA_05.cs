using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_05 : MonoBehaviour
{


    public GameObject player;
    public float distance;

    float evilX;

    //IA
    int xy = 1;
    float timer, timer1, timer2;

    bool rango, rango1, rango2;
    bool time;

    int detectClick = 0;    
    bool goAway, toX, jump;
    float force = 30;

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.transform.tag == "bullet")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3( 100f, 0, 0));
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


    void Update()
    {
        player = GameObject.Find("Player------------------------------------");
        evilX = gameObject.transform.position.x;

        timer += Time.deltaTime;
        if(timer >= 0.5f)
        {
            time = true;
            if(timer >= 3f)
            {
                timer = 0;
            }
        }
        else
        {
            time = false;
        }

        if(time)
        {
            /*if(rango1 && rango2 && goAway == false && jump == false)
            {
                
                if(xy == 2)
                {

                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
                    
                }
                if(xy == 3)
                {

                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -force));
                    
                }
                if(xy == 4)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));

                }
                if(xy == 1)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0, 0));
                }
            }*/


            if(player.gameObject.transform.position.x < evilX + 35 && player.gameObject.transform.position.x > evilX - 35)
            {
                rango = true;
            }


            if(player.gameObject.transform.position.x < evilX + 20 && player.gameObject.transform.position.x > evilX - 20)
            {

                goAway = true;
                if(player.gameObject.transform.position.x < evilX + 15 && player.gameObject.transform.position.x > evilX)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0, 0));
                    toX = true;
                }
                if(player.gameObject.transform.position.x > evilX - 15 && player.gameObject.transform.position.x < evilX)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));
                    toX = false;
                }
            }
            else
            {
                goAway = false;
            }

            if(rango)
            {
                if(player.gameObject.transform.position.x > evilX + 20)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));
                    toX = false;
                    rango1 = false;
                }
                else
                {
                    rango1 = true;
                }

                if(player.gameObject.transform.position.x < evilX - 20)
                {

                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0, 0));
                    toX = true;
                    rango2 = false;
                }
                else
                {
                    rango2 = true;
                }
            }    
        }
    }

}


