using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    bool jump, jump2, notSpam = true;
    float timer, timer2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TouchPlayerMM(Input.mousePosition);
            //Debug.Log("FASE4");
        }

        if(jump)
        {
            timer += Time.deltaTime;
            if(jump2)
            {
                timer2 += Time.deltaTime;
                if(timer2 >= 0.2f)
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,350f,0));
                    timer2 = 0;
                    jump2 = false;
                }
            }

            if(timer >= 1.5f)
            {
                //Debug.Log("FASE0");
                jump = false;
                gameObject.GetComponent<Animator>().SetBool("jumpmm", false);
                timer = 0;
                notSpam = true;
            }
        }
    }

    public void TouchPlayerMM(Vector3 mousePosD)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(mousePosD);
        if(Physics.Raycast(ray, out hit))
        {
            //Debug.Log("FASE3");
            BoxCollider bc = hit.collider as BoxCollider;
            if(bc != null)
            {
//                Debug.Log("FASE2");
                if(bc.transform.tag == "PlayerMM" && notSpam)
                {
                    notSpam = false;
                    jump = true;
                    jump2 = true;
                    gameObject.GetComponent<Animator>().SetBool("jumpmm", true);
                    //Debug.Log("FASE1");
                    
                }
            }
        }
    }
}
