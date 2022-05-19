using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int life = 100;
    public GameObject todo;
    int maxLife;
    int damage;
    bool changeColor;
    float timerColor;
    

    void Start()
    {
        life = Random.Range(90,111);
        maxLife = life;
        damage = maxLife/20;
    }

    void Update()
    {
        if(life <= 0){ Destroy(todo); }

        if(changeColor)
        {
            timerColor += Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.red;
            if(timerColor >= 0.2)
            {
                GetComponent<Renderer>().material.color = Color.white;
                changeColor = false;
                timerColor = 0;
                Debug.Log("ChangeColorBase");

            }
        }

    }


    private void OnTriggerEnter(Collider collision) 
    {
        if (collision.transform.tag == "bullet")
        {
            life -= damage;
        }
    }
}
