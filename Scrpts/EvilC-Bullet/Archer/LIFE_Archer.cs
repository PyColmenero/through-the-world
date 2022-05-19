using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIFE_Archer : MonoBehaviour
{
    public float life = 100;
    public float maxLife;
    float addLife;
    
    public AudioSource hurt1, hurt2, hurt3;
    public float damage;


    int e = 0;
    float x,y,z, rX;
    public GameObject coin, gem;
    public GameObject coinArcher;
    public GameObject destroyy;


    void Start()
    {
        life = 100;
        x = coinArcher.transform.position.x;
        y = coinArcher.transform.position.y;
        z = coinArcher.transform.position.z;

        addLife = Random.Range(-10,10);
        life += addLife;

        switch(PlayerPrefs.GetInt("stageLevel1"))
        {
            case 0:
                life = 300;
            break;  
            case 1:
                life = 340;
            break;
            case 2:
                life = 350;
            break;
            case 3:
                life = 360;
            break;
            case 4:
                life = 380;
            break;
            case 5:
                life = 400;
            break;
        }
        maxLife = life;

        damage  = 34;//PlayerPrefs.GetInt("weapon01Damage");
    }

        float playerPrefsDamage;

    void Update()
    {
        playerPrefsDamage = PlayerPrefs.GetInt("weaponDamgeLevel");
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 1)
        {
            damage *= 9/10; 
        }
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 2)
        {
            damage *= 8/10; 
        }
        if(PlayerPrefs.GetInt("weaponDamgeLevel") == 3)
        {
            damage *= 7/10; 
        }

        x = coinArcher.transform.position.x;
        y = coinArcher.transform.position.y;
        z = coinArcher.transform.position.z;

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
            e = Random.Range(5,11);
            for(int k = 0; k < e ; k++)
            {
                rX = Random.Range(0,2);
                if(rX == 1f) 
                { 
                    rX = 0;
                }
                else
                {
                    rX = 5; 
                }
                Vector3 position = new Vector3(x , y + 5, z);
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
                i = Random.Range(0,3);

                if(i == 0)
                {
                    hurt1.Play();
                }
                if(i == 1)
                {
                    hurt2.Play();
                }
                if(i == 2)
                {
                    hurt3.Play();
                }
            }
        }
    }

    

}
