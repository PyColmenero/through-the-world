using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIA : MonoBehaviour
{


    public GameObject Target;
    public NavMeshAgent agent;
    public float distance;


    //IA
    int move;
    int direction;
    float howMuchDi;
    public double timerR = 0.5;
    int rotate = 0;
    int xy = 1;
    int xyWhile;
    float timer1;
    float timer;
    double timerC;

    int safe = 0;
    int detectClick = 0;
    bool dodge = false;
    int dodgeOrDoesnt;
    

    
    // Update is called once per frame
    void Update()
    {
        

        //IA

        /*if(Vector3.Distance(Target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(Target.transform.position);
            agent.speed = 3;
        }
        else
        {*/

        
        if(Input.GetMouseButtonUp(0))
        {
            timerC = Random.Range(10,40);
            timerC /= 100;
            dodge = true;
            dodgeOrDoesnt = Random.Range(0,4);
        }   

        if(dodge && dodgeOrDoesnt == 0)
        {
             timer += Time.deltaTime;

            if(timer >= timerC)
            {
                detectClick = Random.Range(0,5);
                if(detectClick <= 2)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -200f));
                    dodge = false;
                }
                else
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 200f));
                    dodge = false;
                }
            }
        }
        


        timer1 += Time.deltaTime;
        if(timer1 >= timerR)
        {

                    transform.RotateAround(transform.position, Vector3.up, rotate + 90 * Time.deltaTime);
                    if(xy >= 4)
                        {
                        xy = 1;
                        }
                        else
                        {
                        xy++;
                        }
                        

                    if(xy == 2)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 3)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -100));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 4)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(100f, 0, 0));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 1)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-100f, 0, 0));
                        howMuchDi = Random.Range(2,5);
                    }
                    safe++;

                    if(safe >= 1000)
                    {
                        gameObject.transform.position = new Vector3(-5, 5, 5);
                    }
            
                    if(xy == 2)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 200f));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 3)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -200f));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 4)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(200f, 0, 0));
                        howMuchDi = Random.Range(2,5);
                    }
                    if(xy == 1)
                    {
                        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-200f, 0, 0));
                        howMuchDi = Random.Range(2,5);
                    }

            timerR = Random.Range(1,4);
            timer1=0;
            direction = Random.Range(0,4);
            howMuchDi = Random.Range(2,5);     

            /*if(direction == 0 || direction == 1)
            {
                    transform.RotateAround(transform.position, Vector3.up, rotate + 90 * Time.deltaTime);
                    direction = Random.Range(0,4);
                    if(xy >= 4)
                        {
                        xy = 1;
                        }
                        else
                        {
                        xy++;
                        }

            } 
            else
            {
                        transform.RotateAround(transform.position, Vector3.up, -90  * Time.deltaTime);
                        direction = Random.Range(0,4);
                        if(xy <= 0)
                            {
                            xy = 4;
                            }
                            else
                            {
                                xy--;
                            }
            } */
        }  

       
        

    }



    private void OnTriggerEnter(Collider collision) 
    {
            if(collision.transform.tag == "bullet")
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3( 100f, 0, 0));
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

    }

}


