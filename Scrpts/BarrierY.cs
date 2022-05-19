using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierY : MonoBehaviour
{
    public PlayerControler playerControler;
    public GameObject player, barrier;
    

    bool noMore;


    // Update is called once per frame
    void Update()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        Enemy closestEnemy = null;
        Enemy[] allEnemies = GameObject.FindObjectsOfType<Enemy>();

        foreach (Enemy currentEnemy in allEnemies) 
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy) 
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
            }
        }

        if(closestEnemy != null)
        {
            if(closestEnemy.transform.position.x < gameObject.transform.position.x)
            {
                Destroy(closestEnemy.gameObject);
            }
        }
        


        gameObject.transform.position = new Vector3(gameObject.transform.position.x, playerControler.pControlerY + 1 , 47);

        if(playerControler.pControlerX > gameObject.transform.position.x + 35)
        {
            gameObject.transform.position = new Vector3(playerControler.pControlerX - 35, playerControler.pControlerY + 1, 47);
        }

        if(player.transform.position.x < this.transform.position.x)
        {
            barrier.SetActive(false);
        }
        else
        {
            barrier.SetActive(true);
            
        }

        if(gameObject.transform.position.x >= player.transform.position.x - 5 && gameObject.transform.position.x <= player.transform.position.x + 1)
        {
            //player.GetComponent<Rigidbody>().AddForce(new Vector3(1000f, 0, 0));
            player.transform.position += new Vector3(0.3f,0,0);
//            print("khehf");
        }
    }
}
