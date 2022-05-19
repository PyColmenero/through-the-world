using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSmoke : MonoBehaviour
{

    public PlayerControler playerControler;
    float xPCS;
    public float distanceRender = 10;

    // Start is called before the first frame update
    void Start()
    {
        xPCS = playerControler.gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.position = new Vector3 (playerControler.pControlerX + distanceRender, playerControler.gameObject.transform.position.y + 5f, gameObject.transform.position.z);
        
    }
}
