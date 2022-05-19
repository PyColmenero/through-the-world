using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Image coolDown03, coolDown04, coolDown06, coolDown07;
    public ShootPC shootPC;
    public PotionsGame potionsGame;

    public GameObject coolDown08;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coolDown03 != null) { 
            coolDown03.fillAmount = shootPC.timerBiggerBullet/(shootPC.timeBiggerBullet); 
            if(shootPC.timeBiggerBullet == 0)
                {
                    coolDown03.fillAmount = 0;
                }
            
            }
        if(coolDown04 != null) 
        { 
            coolDown04.fillAmount = potionsGame.timer04/(potionsGame.tiempo04); 
            if(potionsGame.tiempo04 == 0)
            {
                coolDown04.fillAmount = 0;
            }
        }

        if(coolDown06 != null) 
        { 
            coolDown06.fillAmount = potionsGame.timer06/(potionsGame.tiempo06); 
            if(potionsGame.tiempo06 == 0)
            {
                coolDown06.fillAmount = 0;
            }
        }

        if(coolDown07 != null) { coolDown07.fillAmount = potionsGame.timer07/(potionsGame.tiempo07); 
        
        if(potionsGame.tiempo07 == 0)
        {
            coolDown07.fillAmount = 0;
        }
        
        }
        if(coolDown08 != null)
        {
            if(PlayerPrefs.GetInt("potion8ACT") == 1)
            {
                coolDown08.SetActive(true);
            }
            else
            {
                coolDown08.SetActive(false);
            }
        }
        

        

        

        if(Input.GetKeyDown("h"))
        {
            print("timer Bigger " + shootPC.timerBiggerBullet );
            print("tiempo total Bigger " + shootPC.timeBiggerBullet );
            print("timer InstaK " + potionsGame.timer04 );
            print("tiempo total InstaK " + potionsGame.tiempo04 );
        }
    }
}
