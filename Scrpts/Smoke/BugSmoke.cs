using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSmoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MoveSmoke>().enabled = false;
        GetComponent<MoveSmoke>().enabled = true;
//        Debug.Log("BUG");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
