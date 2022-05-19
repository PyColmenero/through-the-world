using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Tank : MonoBehaviour
{

    public LIFE_Tank lIFE_Tank;
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
        life = lIFE_Tank.life / lIFE_Tank.maxLife;
        healthBar.fillAmount = (life);
    }
}
