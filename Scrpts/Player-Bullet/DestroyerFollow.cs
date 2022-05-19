using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerFollow : MonoBehaviour
{
    public GameObject player, dH, dV;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dH.transform.position = new Vector3(transform.position.x - 40, 5, 36);
        dV.transform.position = new Vector3(transform.position.x - 60, 60, 50);
    }
}
