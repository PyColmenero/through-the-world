using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Archer : MonoBehaviour
{

    public LIFE_Archer lIFE_Archer;
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
        life = lIFE_Archer.life / lIFE_Archer.maxLife;
        healthBar.fillAmount = (life);
    }
}
