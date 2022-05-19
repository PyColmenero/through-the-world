using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBarrierStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.Find("EVILCha");
        if(enemy != null)
        {
            if( this.transform.position.x < enemy.transform.position.x)
            {
                Destroy(gameObject);
            }
        }

    }
}
