using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinD : MonoBehaviour
{
    float timer, angA;
    float x, y;
    int i = 0;
    float forceX, forceY;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        forceX = Random.Range(400, 500);
        forceY = Random.Range(200, 250);
        
        angA = gameObject.transform.eulerAngles.y;
        i = Random.Range(0,8);
        if(i == 0)
        {
            x = forceX;
            y = 0; 
        }
        if(i == 1)
        {
            x = -forceX;
            y = 0;
        }
        if(i == 2)
        {
            x = 0;
            y = forceX;
        }
        if(i == 3)
        {
            x = 0;
            y = -forceX;
        }
        if(i == 4)
        {
            x = forceY;
            y = forceY;
        }
        if(i == 5)
        {
            x = -forceY;
            y = forceY;
        }
        if(i == 6)
        {
            x = forceY;
            y = -forceY;
        }
        if(i == 7)
        {
            x = -forceY;
            y = -forceY;
        }

        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x, 0, 0));
    }

    public GameObject player;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.05)
        {
            angA += 5;
            timer = 0;
        }
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, angA, gameObject.transform.eulerAngles.z);


        if(PlayerPrefs.GetInt("potion8ACT") == 1)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            player = GameObject.Find("Player------------------------------------");
            float step =  speed * Time.deltaTime;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, step);
        }
    }
}
