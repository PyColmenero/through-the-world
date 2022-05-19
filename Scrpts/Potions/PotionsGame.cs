using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsGame : MonoBehaviour
{
    public LIFE lIFE;
    public AudioSource drink, wrong;
    public GameObject p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, todoDestroy;
    public GameObject animatorP1;
    int howMuchPotions = 14;
    int a, b, c, d, e, f, g, h, i, j, k;

    public bool shieldChange;

    
    void Start()
    {
        PlayerPrefs.SetInt("potion1ACT" , 0);
        if(PlayerPrefs.GetInt("levelPower02") == 0)
        {
            PlayerPrefs.SetInt("potion2ACT", 0);
        }
        else
        {
            PlayerPrefs.SetInt("potion2ACT", 1);
        }
        PlayerPrefs.SetInt("potion3ACT" , 0);
        PlayerPrefs.SetInt("potion7ACT" , 0);
        PlayerPrefs.SetInt("potion8ACT" , 0);
        PlayerPrefs.SetInt("potion12ACT", 0);
        PlayerPrefs.SetInt("potion13ACT", 0);

        tiempo04 = 0;
        tiempo07 = 0;

        if (PlayerPrefs.GetInt("potion0") <= 0 && a == 0)
        {
            Destroy(p0);
            howMuchPotions--;
            a++;
        }
        if (PlayerPrefs.GetInt("potion1") <= 0 && b == 0)
        {
            Destroy(p1);
            howMuchPotions--;
            b++;
        }
        if (PlayerPrefs.GetInt("potion2") <= 0 && c == 0)
        {
            Destroy(p2);
            howMuchPotions--;
            c++;
        }
        if (PlayerPrefs.GetInt("potion3") <= 0 && d == 0)
        {
            Destroy(p3);
            howMuchPotions--;
            d++;
        }
        if (PlayerPrefs.GetInt("potion4") <= 0 && e == 0)
        {
            Destroy(p4);
            howMuchPotions--;
            e++;
        }
        if (PlayerPrefs.GetInt("potion5") <= 0 && f == 0)
        {
            Destroy(p5);
            howMuchPotions--;
            f++;
        }
        if (PlayerPrefs.GetInt("potion6") <= 0 && g == 0)
        {
            Destroy(p6);
            howMuchPotions--;
            g++;
        }
        if (PlayerPrefs.GetInt("potion7") <= 0 && h == 0)
        {
            Destroy(p7);
            howMuchPotions--;
            h++;
        }
        if (PlayerPrefs.GetInt("potion8") <= 0)
        {
            Destroy(p8);
            howMuchPotions--;
        }
        if (PlayerPrefs.GetInt("potion9") <= 0)
        {
            Destroy(p9);
            howMuchPotions--;
        }
        if (PlayerPrefs.GetInt("potion10") <= 0)
        {
            Destroy(p10);
            howMuchPotions--;
        }
        if (PlayerPrefs.GetInt("potion11") <= 0)
        {
            Destroy(p11);
            howMuchPotions--;
        }
        if (PlayerPrefs.GetInt("potion12") <= 0)
        {
            Destroy(p12);
            howMuchPotions--;
        }
        if (PlayerPrefs.GetInt("potion13") <= 0)
        {
            Destroy(p13);
            howMuchPotions--;
        }
        shieldChange = false;

        if (howMuchPotions <= 0)
        {
            Destroy(todoDestroy);
        }
    }

    
    void Update()
    {
        


        if(PlayerPrefs.GetInt("potion1ACT") == 1)
        {
            timer02 += Time.deltaTime;
            animatorP1.SetActive(true);
            if(timer02 >= tiempo02)
            {
                timer02 = 0;
                PlayerPrefs.SetInt("potion1ACT", 0);
                animatorP1.GetComponent<Animator>().SetBool("coolDown", false);
                animatorP1.SetActive(false);
                PlayerPrefs.SetInt("potion1", PlayerPrefs.GetInt("potion1") - 1);
            }
        }

        if(PlayerPrefs.GetInt("potion2ACT") == 1)
        {
            potion2Animator.SetActive(true);
        }

        if(PlayerPrefs.GetInt("potion4ACT") == 1)
        {
            timer04 += Time.deltaTime;
            if(timer04 >= tiempo04)
            {
                timer04 = 0;
                tiempo04 = 0;
                PlayerPrefs.SetInt("potion4ACT", 0);
            }
        }

        if(PlayerPrefs.GetInt("potion6ACT") == 1)
        {
            timer06 += Time.deltaTime;
            if(timer06 >= tiempo06)
            {
                timer06 = 0;
                tiempo06 = 0;
                PlayerPrefs.SetInt("potion6ACT", 0);
            }
        }


        if(PlayerPrefs.GetInt("potion7ACT") == 1)
        {
            timer07 += Time.deltaTime;
            if(timer07 >= tiempo07)
            {
                timer07 = 0;
                tiempo07 = 0;
                PlayerPrefs.SetInt("potion7ACT", 0);
            }
        }
    }

    public GameObject potion2Animator;

    float timer02;
    public float timer04, timer06, timer07;
    int tiempo02 = 12;
    public int tiempo04 = 20, tiempo06 = 20, tiempo07;

    public void usePotion00()
    {
        //ADD HEALTH
        if(PlayerPrefs.GetInt("potion0") >= 1)
        {
            //PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") - 2000);
            PlayerPrefs.SetInt("potion0", PlayerPrefs.GetInt("potion0") - 1);
            lIFE.health += 200;
            drink.Play();
        }
        else
        {
            wrong.Play();
        }
    }
    public void usePotion01()
    {
        //INVINCIBILITY
        if(PlayerPrefs.GetInt("potion1") >= 1 && PlayerPrefs.GetInt("potion1ACT") == 0)
        {
            drink.Play();
            PlayerPrefs.SetInt("potion1ACT", 1);
        }
        else
        {
            wrong.Play();
        }    
    }
    public void usePotion02()
    {
        //EXTRA LIFE
        if(PlayerPrefs.GetInt("potion2") >= 1 && PlayerPrefs.GetInt("potion2ACT") == 0)
        {
            PlayerPrefs.SetInt("potion2", PlayerPrefs.GetInt("potion2") - 1);
            PlayerPrefs.SetInt("potion2ACT", 1);
            drink.Play();
            
        }
        else
        {
            wrong.Play();
        }    
    }
    public void usePotion03()
    {
        //BIGGER BULLET
        if(PlayerPrefs.GetInt("potion3") >= 1)
        {
            PlayerPrefs.SetInt("potion3ACT" , 1);
            PlayerPrefs.SetInt("potion3", PlayerPrefs.GetInt("potion3") - 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
    public void usePotion04()
    {
        //INSTA KILL
        if(PlayerPrefs.GetInt("potion4") >= 1)
        {
            tiempo04 += 10;
            PlayerPrefs.SetInt("potion4", PlayerPrefs.GetInt("potion4") - 1);
            PlayerPrefs.SetInt("potion4ACT", 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
    int howMuchShields = 0;
    public void usePotion05()
    {
        //SHIELD
        if(PlayerPrefs.GetInt("potion5") >= 1)
        {
            PlayerPrefs.SetInt("potion5", PlayerPrefs.GetInt("potion5") - 1);
            shieldChange = true;
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
    public GameObject player;
    public void usePotion06()
    {
        //GET SMALL
        if(PlayerPrefs.GetInt("potion6") >= 1)
        {
            tiempo06 += 10;
            PlayerPrefs.SetInt("potion6", PlayerPrefs.GetInt("potion6") - 1);
            PlayerPrefs.SetInt("potion7ACT", 1);
            player.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
    public void usePotion07()
    {
        //MISSILE
        if(PlayerPrefs.GetInt("potion7") >= 1)
        {
            tiempo07 += 10;
            PlayerPrefs.SetInt("potion7", PlayerPrefs.GetInt("potion7") - 1);
            PlayerPrefs.SetInt("potion7ACT", 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
    public void usePotion08()
    {
        //MAGNET MONEY
        if(PlayerPrefs.GetInt("potion8") >= 1 && PlayerPrefs.GetInt("potion8ACT") == 0)
        {
            PlayerPrefs.SetInt("potion8", PlayerPrefs.GetInt("potion8") - 1);
            PlayerPrefs.SetInt("potion8ACT", 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }

    public ShootPC shootPC;
    
    public void usePotion09()
    {
        // VERTICAL BULLET
        if(PlayerPrefs.GetInt("potion9") >= 1)
        {
            PlayerPrefs.SetInt("potion9", PlayerPrefs.GetInt("potion9") - 1);
            shootPC.forHMDA++;
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }

    public void usePotion10()
    {
        // HORIZONTAL BULLET
        if(PlayerPrefs.GetInt("potion10") >= 1)
        {
            PlayerPrefs.SetInt("potion10", PlayerPrefs.GetInt("potion10") - 1);
            shootPC.forHMA++;
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }

    public void usePotion11()
    {
        //MAGNET MONEY
        if(PlayerPrefs.GetInt("potion11") >= 1)
        {
            PlayerPrefs.SetInt("potion11", PlayerPrefs.GetInt("potion11") - 1);
            shootPC.yTimeShoot -= shootPC.yTimeShoot / 10;
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }

    public void usePotion12()
    {
        //MAGNET MONEY
        if(PlayerPrefs.GetInt("potion12") >= 1)
        {
            PlayerPrefs.SetInt("potion12", PlayerPrefs.GetInt("potion12") - 1);
            PlayerPrefs.SetInt("potion12ACT", PlayerPrefs.GetInt("potion12ACT") + 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }

    public void usePotion13()
    {
        //MAGNET MONEY
        if(PlayerPrefs.GetInt("potion13") >= 1)
        {
            PlayerPrefs.SetInt("potion13", PlayerPrefs.GetInt("potion13") - 1);
            PlayerPrefs.SetInt("potion13ACT", PlayerPrefs.GetInt("potion13ACT") + 1);
            drink.Play();
        }
        else
        {
            wrong.Play();
        }    
    }
}
