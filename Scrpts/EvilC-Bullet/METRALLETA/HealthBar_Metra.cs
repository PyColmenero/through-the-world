using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Metra : MonoBehaviour
{

    public LIFE_Metralleta lIFE_Metralleta;
    Image healthBar;
    float life;
    
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        life = lIFE_Metralleta.life / lIFE_Metralleta.maxLife;
        if(healthBar != null)
        {
            healthBar.fillAmount = (life);
        }
    }
}
