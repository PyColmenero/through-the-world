using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIFE_Tank: MonoBehaviour
{
    public GameObject todo;
    public AudioSource hurt1;
    public float life = 200;
    public float maxLife;
    bool changeColor;
    float timerColor;

    float addLife;
    
    public float damage;
    float playerPrefsDamage;

    int i = 0;
    float x,y,z, rX;
    public GameObject coin, gem;

    void Start()
    {
        life = 200;
        addLife = Random.Range(0,20);
        life += addLife;


        switch(PlayerPrefs.GetInt("stageLevel1"))
        {
            case 0:
                life = 200;
            break;  
            case 1:
                life = 220;
            break;
            case 2:
                life = 240;
            break;
            case 3:
                life = 250;
            break;
            case 4:
                life = 270;
            break;
            case 5:
                life = 300;
            break;
        }
        maxLife = life;

        damage  = 25;
        
    }

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

        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;

        if (PlayerPrefs.GetInt("addBulletDamage") != 0)
        {
            damage *= 1 + PlayerPrefs.GetInt("addBulletDamage") / 5;
        }

        if (life <= 0)
        { 
            int gemOrNot = Random.Range(0,11);
            if(gemOrNot == 5)
            {
                Vector3 position = new Vector3(x , y+1, z);
                Quaternion rotation = new Quaternion(0, rX, 0, rX);
                Instantiate(gem, position, rotation);
            }
            i = Random.Range(5,11);
            for(int k = 0; k < i ; k++)
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
                Vector3 position = new Vector3(x , y + 1, z);
                Quaternion rotation = new Quaternion(0, rX, 0, rX);
                Instantiate(coin, position, rotation);
            }
            
            Destroy(todo); 
        }

    }

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
                hurt1.Play();
            }
        }
    }

}
