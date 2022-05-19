using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugCamera : MonoBehaviour
{
    void Start()
    {
        GetComponent<CameraMove>().enabled = false;
        GetComponent<CameraMove>().enabled = true;
    }
}
