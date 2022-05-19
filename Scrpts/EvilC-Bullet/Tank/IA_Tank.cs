using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_Tank : MonoBehaviour
{

    public GameObject animator;
    public GameObject Target;
    public NavMeshAgent agent;
    public GameObject player;
    float evilX;


    //IA
    double timerR = 1.5;
    float timer;
    int xy = 1;
    float timer1;
    bool rango, rango1, rango2;
    float force = 20;

    int detectClick = 0;
    
    bool goAway, toX, jump;
    
    // Update is called once per frame
    void Update()
    {

        player = GameObject.Find("Player------------------------------------");
        evilX = gameObject.transform.position.x;

        timer1 += Time.deltaTime;
        if(timer1 >= timerR)
        {
            force = Random.Range(130,170);
            if(rango1 && rango2 && goAway == false && jump == false)
            {
                animator.GetComponent<Animator>().SetBool("Run", true);
                xy = Random.Range(1,5);
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
            }
            else
            {
                animator.GetComponent<Animator>().SetBool("Run", false);
            }

            if(player.gameObject.transform.position.x < evilX + 25 && player.gameObject.transform.position.x > evilX - 25)
            {
                rango = true;
            }

            if(player.gameObject.transform.position.x < evilX + 13 && player.gameObject.transform.position.x > evilX - 13)
            {
                animator.GetComponent<Animator>().SetBool("Run", true);
                goAway = true;
                if(player.gameObject.transform.position.x < evilX + 13 && player.gameObject.transform.position.x > evilX)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0, 0));
                    toX = true;
                }
                if(player.gameObject.transform.position.x > evilX - 13 && player.gameObject.transform.position.x < evilX)
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
                if(player.gameObject.transform.position.x > evilX + 17)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));
                    toX = false;
                    rango1 = false;
                }
                else
                {
                    rango1 = true;
                }

                if(player.gameObject.transform.position.x < evilX - 17)
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

            timerR = Random.Range(11,21);
            timerR /= 10;
            timer1 = 0;
   

        }  
    }


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
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-45, 65, 0));
            }
            else
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(45, 65, 0));
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