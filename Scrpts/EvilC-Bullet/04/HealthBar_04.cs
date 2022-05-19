using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_04 : MonoBehaviour
{

    public LIFE_04 lIFE_04;
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
        life = lIFE_04.life / lIFE_04.maxLife;
        healthBar.fillAmount = (life);
    }
}
