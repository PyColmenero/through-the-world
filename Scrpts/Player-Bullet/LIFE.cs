using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIFE : MonoBehaviour
{

    public AudioSource damage;
    public GameObject died, playButtons;
    public MONEY mONEY;
    public float health, healthRemovedArcher, healthRemovedMetra, healthRemovedTank, healthRemoved04, healthRemoved05;
    float timerV;
    bool v1;
    public GameObject potion1Animator, potion2Animator;
    public AudioSource extraLife;
    float timerPotion2;
    bool timerPotion22;

    bool lava;

    public float maxHealth;
    
    void Start()
    {
        switch(PlayerPrefs.GetInt("levelPower00"))
        {
            case 0:
                health = 1000;
            break;
            case 1:
                health = 1200;
            break;
            case 2:
                health = 1500;
            break;
            case 3:
                health = 2000;
            break;
            case 4:
                health = 3000;
            break;
            case 5:
                health = 5000;
            break;
        }
        maxHealth = health;

        switch(PlayerPrefs.GetInt("levelPower01"))
        {
            case 0:
                        healthRemovedArcher = 10;
                        healthRemovedMetra = 5;
                        healthRemovedTank = 35;
                        healthRemoved04 = 60;
                        healthRemoved05 = 70;
            break;
            case 1:
                        healthRemovedArcher = 9;
                        healthRemovedMetra = 4;
                        healthRemovedTank = 32;
                        healthRemoved04 = 56;
                        healthRemoved05 = 62;
            break;
            case 2:
                        healthRemovedArcher = 8;
                        healthRemovedMetra = 3;
                        healthRemovedTank = 28;
                        healthRemoved04 = 50;
                        healthRemoved05 = 56;
            break;
            case 3:
                        healthRemovedArcher = 7;
                        healthRemovedMetra = 2;
                        healthRemovedTank = 24;
                        healthRemoved04 = 46;
                        healthRemoved05 = 50;
            break;
            case 4:
                        healthRemovedArcher = 5;
                        healthRemovedMetra = 1;
                        healthRemovedTank = 20;
                        healthRemoved04 = 40;
                        healthRemoved05 = 35;

            break;
            case 5:
                        healthRemovedArcher = 4;
                        healthRemovedMetra = 1;
                        healthRemovedTank = 15;
                        healthRemoved04 = 35;
                        healthRemoved05 = 30;
            break;
            case 6:
                        healthRemovedArcher = 3;
                        healthRemovedMetra = 1;
                        healthRemovedTank = 10;
                        healthRemoved04 = 30;
                        healthRemoved05 = 25;
            break;
            case 7:
                        healthRemovedArcher = 3;
                        healthRemovedMetra = 1;
                        healthRemovedTank = 5;
                        healthRemoved04 = 25;
                        healthRemoved05 = 20;
            break;
        }
        if(PlayerPrefs.GetInt("levelPower02") == 0)
        {
            PlayerPrefs.SetInt("potion2ACT", 0);
        }
        else
        {
            PlayerPrefs.SetInt("potion2ACT", 1);
        }
    }

    int total;
    int i = 0;
    public float deathTimer;

    void Update()
    {
        if(health > maxHealth)
        {
            health = maxHealth;
        }

        if(health <= 0)
        {
            if(PlayerPrefs.GetInt("potion2ACT") == 0)
            {
                if (i == 0)
                {
                    i = 1;
                    Debug.Log(total + " , " + mONEY.moneyAmount);
                    died.SetActive(true);
                    playButtons.SetActive(false);
                }
                deathTimer += Time.deltaTime;
                if(deathTimer >= 1f)
                {
                    Time.timeScale = 0f;
                }
            }
            else
            {
                PlayerPrefs.SetInt("potion2ACT", 0);
                health = maxHealth;
                extraLife.Play();
                timerPotion22 = true;
                PlayerPrefs.SetInt("potion8ACT", 0);
                if(potion1Animator != null)
                {
                    potion1Animator.SetActive(false);
                }

            }
        }

        if(timerPotion22)
        {
            
            timerPotion2 += Time.deltaTime;
            if(timerPotion2 >= 0.5f)
            {
                if(potion2Animator != null)
                {
                    potion2Animator.SetActive(false);
                }
                
                timerPotion2 = 0;
                timerPotion22 = false;
            }
        }

        
        timerV += Time.deltaTime;
        if(timerV >= 0.2f)
        {
            v1 = true;
        }
        else
        {
            v1 = false;
        }

        if(lava)
        {
            health -= 5;
        }

        if(health <= 0)
        {
            health = 0;
        }
        
    }

    public float thrust;

    private void OnTriggerEnter(Collider other) 
    {
        if(PlayerPrefs.GetInt("potion1ACT") == 0)
        {

            if (other.transform.tag == "bulletEvil05")
            {
                gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * thrust);
                damage.Play();
                health -= healthRemovedArcher;
            }

            if (other.transform.tag == "EvilBulletArcher")
            {
                damage.Play();
                health -= healthRemovedArcher;
                Destroy(other.gameObject);
            }
            if (other.transform.tag == "EvilBulletMetra")
            {
                damage.Play();
                health -= healthRemovedMetra;
       //         print("metraAttac");
                Destroy(other.gameObject);
                other.transform.position += new Vector3(0,1000,0);
            }
            if (other.transform.tag == "EvilBulletTank")
            {
                if (v1)
                {
                    v1 = false;
                    timerV = 0;
                    damage.Play();
                    health -= healthRemovedTank;
                    Destroy(other.gameObject);
                }
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "lava" && health > 0)
        {
            lava = true;
        }
        else
        {
            lava = false;
        }
        if (collision.transform.tag == "bulletEvil05")
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * thrust);
            damage.Play();
            health -= healthRemovedArcher;
        }
    }
}
