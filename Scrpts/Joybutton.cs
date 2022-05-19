using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    [HideInInspector]
    public bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        Debug.Log("BUTTON1");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
        Debug.Log("BUTTON2");
    }


}
