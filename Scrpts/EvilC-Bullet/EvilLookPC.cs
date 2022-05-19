using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilLookPC : MonoBehaviour
{
    public DetectPlayer detectPlayer;
     GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player------------------------------------");

        if(player.gameObject.transform.position.x < gameObject.transform.position.x + 20 && player.gameObject.transform.position.x > gameObject.transform.position.x - 20)
        {
            gameObject.transform.eulerAngles = new Vector3(0, detectPlayer.angA, 0);
        }
    }
}
