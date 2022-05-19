using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_05 : MonoBehaviour
{

    public LIFE_05 lIFE_05;
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
        life = lIFE_05.life / lIFE_05.maxLife;
        healthBar.fillAmount = (life);
    }
}
