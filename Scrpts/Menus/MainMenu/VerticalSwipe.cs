using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSwipe : MonoBehaviour
{

    public float xCS, x;
    public float move;
    public bool first;
    public int stopFase;

    public float speed = 10;
    float step;
    public Vector3 instantaiatePoint;
    public int coolDown;
    public int speedSwipeX, speedSwipeY, speedXS;
    public float timerS;
    public bool vSwipe;
    public Swipe swipe;

    public int upOrDown;
    public bool first1;
    float timerHS;

    float firstClick, lastClick;
    public float spaceClicK;
    float timerSlide;

    public float spaceRemoved;
 
    void Start()
    {
        gameObject.transform.position = new Vector3(51, gameObject.transform.position.y, 0);
        coolDown = 60;
        speedXS = 3;
        instantaiatePoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        step =  speed * Time.deltaTime;

        if(Input.GetMouseButton(0) && swipe.hSwipe == false  /* && gameObject.transform.position.x < 260*/)
        {
            timerSlide += Time.deltaTime;
            timerHS = 0;
            timerS += Time.deltaTime;
            x = Input.mousePosition.y;
            if(first)
            {
                firstClick = Input.mousePosition.y;
                first = false;
                xCS = x;
            }
            
            if(x >= xCS + coolDown && gameObject.transform.position.y <= instantaiatePoint.y + 55)
            {
                vSwipe = true;
                coolDown = 1;
                move += speedXS;
                xCS = x;
                speedSwipeX++;
                speedSwipeY = 0;
                upOrDown = 0;
            }
            if(x <= xCS - coolDown && gameObject.transform.position.y >= instantaiatePoint.y + 5)
            {
                vSwipe = true;
                coolDown = 1;
                xCS = x;
                move-= speedXS;
                speedSwipeY++;
                speedSwipeX = 0;
                upOrDown = 1;
            }
            move /= 5;
            
            gameObject.transform.position = new Vector3(51, gameObject.transform.position.y + move, 0);
            stopFase = 0;
            first1 = true;
        }
        else
        { 
            if(first1)
            {
                lastClick = Input.mousePosition.y;
                spaceClicK = lastClick - firstClick;
                if(spaceClicK < 0)
                {
                    spaceClicK *= -1;
                }
                spaceClicK /= timerSlide;
                first1 = false;
                if(upOrDown == 0)
                {
                    move = spaceClicK/700;
                }
                else
                {
                    move = -(spaceClicK/700);
                }
                timerSlide = 0;
                spaceRemoved = 0.2f;
            }
            else


            if(move >= -0.2 && move <= 0.2)
            {
                upOrDown = -1;
                move = 0;
            }
            if(gameObject.transform.position.y <= instantaiatePoint.y + 5)
            {
                upOrDown = -1;
                move = 0;
            }
            if(gameObject.transform.position.y >= instantaiatePoint.y + 55)
            {
                upOrDown = -1;
                move = 0;
            }
            if(upOrDown == 0)
            {
                gameObject.transform.position = new Vector3(51, gameObject.transform.position.y + move, 0);
                move -= spaceRemoved;
                

            }
            if(upOrDown == 1)
            {
                gameObject.transform.position = new Vector3(51, gameObject.transform.position.y + move, 0);
                move += 0.2f;
            } 
            if(move == 0)
            {
                upOrDown = -1;
            }

            timerHS += Time.deltaTime;
            if(timerHS >= 0.2f)
            {
                vSwipe = false;
            }
        // -111.5 -105.5  -9.5     48 51 55      -7 0  +7     -49 -42 -54       97.5  102.5  111.5
            timerS = 0;
            coolDown = 10;
            speedXS = 9;
            speedSwipeX = 0;
            speedSwipeY = 0;
            xCS = x;
            first = true;
        // -111.5 -105.5  -9.5     48 51 55      -7 0  +7     -49 -42 -54       97.5  102.5  111.5
        } 
    
    }
}
