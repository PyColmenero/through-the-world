using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIFE_Metralleta : MonoBehaviour
{
    public AudioSource hurt1, hurt2;

    public float life = 100;
    public float maxLife;
    bool changeColor;
    float timerColor;
    float addLife;

    float damage;
    float damage1;
    float damage2;
    float damage3;
    float damage4;

    int e = 0;
    float x,y,z, rX;
    public GameObject coin, gem;
    public GameObject coinMetra;
    public GameObject destroyy;

    void Start()
    {
        life = 100;

        x = coinMetra.transform.position.x;
        y = coinMetra.transform.position.y;
        z = coinMetra.transform.position.z;

        addLife = Random.Range(0,10);
        life += addLife;
        
        switch(PlayerPrefs.GetInt("stageLevel1"))
        {
            case 0:
                life = 120;
            break;  
            case 1:
                life = 140;
            break;
            case 2:
                life = 150;
            break;
            case 3:
                life = 160;
            break;
            case 4:
                life = 180;
            break;
            case 5:
                life = 200;
            break;
        }
        maxLife = life;

        damage  = 34;
        /*damage1 = maxLife/ 2564;
        damage2 = maxLife/ 2439;
        damage3 = maxLife/ 2439;
        damage4 = maxLife/ 1811;*/
    }

    float playerPrefsDamage;

    void Update()
    {
        playerPrefsDamage = PlayerPrefs.GetInt("weaponDamgeLevel");
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 1)
        {
            damage *= 0.9f; 
        }
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 2)
        {
            damage *= 0.8f; 
        }
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 3)
        {
            damage *= 0.7f; 
        }

        x = coinMetra.transform.position.x;
        y = coinMetra.transform.position.y;
        z = coinMetra.transform.position.z;

        if(PlayerPrefs.GetInt("addBulletDamage") != 0)
        {
            damage *= 1 + PlayerPrefs.GetInt("addBulletDamage") / 5;
        }
        
        if(life <= 0)
        { 
            int gemOrNot = Random.Range(0,11);
            if(gemOrNot == 5)
            {
                Vector3 position = new Vector3(x , y+1, z);
                Quaternion rotation = new Quaternion(0, rX, 0, rX);
                Instantiate(gem, position, rotation);
            }
            e = Random.Range(5,11);
            for(int k = 0; k < e ; k++)
            {
                rX = Random.Range(0,2);
                if(rX == 1) 
                { 
                    rX = 0;
                }
                else
                {
                    rX = 5; 
                }
                Vector3 position = new Vector3(x , y+1, z);
                Quaternion rotation = new Quaternion(0, rX, 0, rX);
                Instantiate(coin, position, rotation);
            }
            
            Destroy(destroyy); 
        }

    }
    int i = 0;
    

    private void OnTriggerEnter(Collider collision) 
    {
        if (collision.transform.tag == "bullet")
        {
            if(PlayerPrefs.GetInt("potion4ACT") == 1)
            {
                life -= 1000;
            }
            else
            {
//                print(PlayerPrefs.GetInt("weapon"));
                switch(PlayerPrefs.GetInt("weapon"))
                {
                    case 0:
                        life -= damage;
                        break;

                    case 1:
                        life -= damage * 1.5f;
                        break;

                    case 2:
                        life -= damage * 2.0f;
                        break;

                    case 3:
                        life -= damage * 2.5f;
                        break;
                    case 4:
                        life -= damage * 3f;
                        break;
                }
            }

            if(PlayerPrefs.GetInt("evilSound") == 0)
            {
                i = Random.Range(0,2);

                if(i == 0)
                {
                    hurt1.Play();
                }
                if(i == 1)
                {
                    hurt2.Play();
                }
            }

        }

    }
}
