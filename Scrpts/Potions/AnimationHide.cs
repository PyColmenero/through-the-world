using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationHide : MonoBehaviour
{

    bool hide;
    public GameObject animator;
    public Text flechitas;

    void Start() 
    {
        animator.GetComponent<Animator>().SetBool("hide", false);
    }

    void Update()
    {
        
    }
    public void hideButton()
    {
        if(hide)
        {
            hide = false;
            animator.GetComponent<Animator>().SetBool("hide", false);
            flechitas.text = ">>>>";
        }
        else
        {
            hide = true;
            animator.GetComponent<Animator>().SetBool("hide", true);
            flechitas.text = "<<<<";
        }
    }
}
