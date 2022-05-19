using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOOK_Archer : MonoBehaviour
{
    public DetectPC_Archer detectPC_Archer;
     GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y >= 1000)
        {
            Destroy(gameObject);
        }
        if(gameObject.transform.position.y <= -100)
        {
            Destroy(gameObject);
        }

        player = GameObject.Find("Player------------------------------------");

        if(player.gameObject.transform.position.x < gameObject.transform.position.x + 30 && player.gameObject.transform.position.x > gameObject.transform.position.x - 30)
        {
            gameObject.transform.eulerAngles = new Vector3(0, detectPC_Archer.angA, 0);
        }
    }
}
