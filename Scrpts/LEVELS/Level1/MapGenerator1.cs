using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapGenerator1 : MonoBehaviour
{
    public int howMuchEvil01, howMuchEvil02, howMuchEvil03,howMuchEvil04, howMuchEvil05;
    public GameObject block1Prefab;
    public GameObject block2Prefab;
    public GameObject block3Prefab, block3Prefab1, block3Prefab2, block3Prefab3, block3Prefab4, block3Prefab5, block3Prefab6;
    public GameObject evilChaPrefabMetra, evilChaPrefabTank, evilChaPrefabArcher, evilChaPrefab04, evilChaPrefab05;
    public GameObject torch;
    public GameObject wall, wall1;
    public GameObject altarPrefab;
    public GameObject lastWall, tramp01;

    public int whithEvilMax, whithEvilMin;

    public GameObject desert1, desert2, desert3, desert4, desert5;
    public GameObject desertS1, desertS2, desertS3, desertS4, desertS5;
    public GameObject rot1, rot2, rot3, rot4, rot5, rot6, rot7, rot8;
    int hmD, wD, rl, rot, randomDP, specialWD, specialHMD, rCS; 
    float xD, yD;
    float lxD, lyD;
    bool randomDesert, p1,p2;
    float[] desertX = new float[10];
    float[] desertY = new float[10];

    public PlayerControler playerControler;
    int light20 = 21;
    bool b1;

    int x = 10;
    float xW = 18.8f, yW = 62, zW = 63f;
    int z = 10;
    int sizeY = 200;
    int[] y = new int[1000];
    int rY;
    
    int chooseEnemy = 0;
    int howMuchEnemys, howMuchEnemys2 = 0;

    int diferentBases = 8;

    int s = 0;
    int e = 0, e1 = 0, e2 = 0;   
    int maxStairsSizeUp = 2, maxStairsSizeDown = 2;
    int j = 1;

    bool detector1, detector2, detector3, base3 = true;
    bool yOnce;

    //int sizeX = 15;

    int evil = 0;    
    

    float pCX, pCCS, pCCSWall, pCYWall;
    float dieciNueve;

    int altar, altarCounter = 0;
    bool altarStop, detector3Altar;

    int collision;
    float xStart; 
    int noMobs;
    bool noMobsb; 
    int everyAltar = 50;
    int howManyMobs = 18, howManyMobsS = 17;
    public GameObject nextLevel;
//    int escaleraAltar = 0;
    public int primer = -1;

    int baseSet;
    bool baseYesNO;
    int lastBase;

    void Start()
    {
        howMuchEvil01 = 0;
        howMuchEvil02 = 0;
        howMuchEvil03 = 0;
        howMuchEvil04 = 0;
        howMuchEvil05 = 0;

        howManyMobsS = 17;
        howManyMobs = 18;
        whithEvilMax = 12;
        whithEvilMin = 2;


        PlayerPrefs.SetInt("stageLevel1", -1);
        yOnce = true;
        pCX = playerControler.pControlerX;
        pCCS = pCX -= 100;
        xStart = pCX;
        pCCSWall = pCX -23.6f;
        dieciNueve = 19.6f;
        pCYWall = playerControler.pControlerY - dieciNueve;

        altar = Random.Range(35,45);
        z = 47;
        //specialD = 5;
    }
    void Update()
    {
        if(altarStop == false)
        {
            pCX = playerControler.pControlerX;
        }

        if(yOnce)
        {
            for(; s < sizeY; s++)
            {
                y[s] = 55;
            }
            s = 0;
            yOnce = false;
        }

        if(pCX > pCCSWall)
        {

            Vector3    position  = new Vector3(xW + 23.6f, yW-1f, zW - 26f);
            Quaternion rotation  = new Quaternion(0,0,0,0);
            Instantiate(wall, position, rotation);
            Vector3    position1 = new Vector3(xW + 23.6f, yW -20.6f, zW - 26f);
            Quaternion rotation1 = new Quaternion(0,0,0,0);
            Instantiate(wall, position1, rotation1);
            Vector3    position3 = new Vector3(xW + 23.6f, yW + 18.6f, zW - 26f);
            Quaternion rotation3 = new Quaternion(0,0,0,0);
            Instantiate(wall, position3, rotation3);



            Vector3 position11 = new Vector3(xW, yW, zW);
            Quaternion rotation11 = new Quaternion(0,0,0,0);
            Instantiate(wall1, position11, rotation11);
            Vector3 position22 = new Vector3(xW, yW + dieciNueve, zW);
            Quaternion rotation22 = new Quaternion(0,0,0,0);
            Instantiate(wall1, position22, rotation22);
            Vector3 position44 = new Vector3(xW, yW - dieciNueve, zW);
            Quaternion rotation44 = new Quaternion(0,0,0,0);
            Instantiate(wall1, position44, rotation44);

            xW += 11.8f;
            pCCSWall += 11.8f;     

            //if(playerControler.pControlerX < )       

        }
//        print("primer " + primer);
        PlayerPrefs.SetInt("stageLevel1", primer);

// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------


        if(pCX > pCCS)
        {
            collision++;
            
            //ALTAR
            if(altarCounter >= altar-2){ evil = 0; }
            if(altarCounter >= altar && detector3Altar == true)
            {
//                print("bases " + baseSet);
                PlayerPrefs.SetInt("stageLevel1", primer);


                if(primer == 3)
                {
                    howManyMobsS = 1;
                    howManyMobs = 4;
                    whithEvilMax = 28;
                    whithEvilMin = 6;
                }

                if(primer == 2)
                {
                    primer++;
                    howManyMobsS = 2;
                    howManyMobs = 9;
                    whithEvilMax = 25;
                    whithEvilMin = 5;
                }

                if(primer == 1)
                {
                    primer++;
                    howManyMobsS = 2;
                    howManyMobs = 16;
                    whithEvilMax = 20;
                    whithEvilMin = 3;
                }

                if(primer == 0)
                {
                    primer++;
                    howManyMobsS = 4;
                    howManyMobs = 16;
                    whithEvilMax = 18;
                    whithEvilMin = 2;
                }

                if(primer == -1)
                {
                    primer++;
                    howManyMobsS = 17;
                    howManyMobs = 18;
                    whithEvilMax = 12;
                    whithEvilMin = 2;
                }

                
                Vector3 position = new Vector3(x , y[j - 1] + 0.8f, 47);
                Quaternion rotation = new Quaternion(0,0,0,0);
                Instantiate(altarPrefab, position, rotation);
                everyAltar += 10; 
                altar = Random.Range(everyAltar - 5, everyAltar + 10);
                altarCounter = 0;
                detector3 = true;
                detector1 = false;
                detector2 = false;
                noMobsb = true;
                howManyMobs -= 1;

                if(primer == 4)
                {
                    Vector3 positionNL = new Vector3(x-2, y[j - 1] + 5f, z);
                    Quaternion rotationNL = rot1.transform.rotation;
                    Instantiate(nextLevel, positionNL, rotationNL);
                    
                    Vector3 position1 = new Vector3(x + 5f , y[j - 1] + 17.5f, z-5f);
                    Quaternion rotation1 = rot4.transform.rotation;
                    Instantiate(lastWall, position1, rotation1);
                    pCCS = pCX + 2;
                    altarStop = true;
                }
            }
            if(noMobsb)
            {
                evil = 0;
                noMobs++;
                if(noMobs >=3)
                {
                    noMobsb = false;
                }
            }
            //Debug.Log(pCX + " PCX " + pCCS);
                    
                    rY = Random.Range(0,22);

                    if(detector1 == true) 
                    {
                        if(e <= maxStairsSizeDown)
                        {
                            rY=0; 
                            e++;
                            detector2 = false;
                            detector3 = false;
                            
                        }
                        else
                        {
                            detector1 = false;
                            detector2 = false;
                            e=0;
                            e1=0;
                            e2=0;
                            detector3 = true;
                        
                        }
                    }

                    if(detector2 == true) 
                    {
                        if(e1 <= maxStairsSizeUp)
                        {
                            rY=3; 
                            e1++;
                            detector1 = false;
                            detector3 = false;
                        }
                        else
                        {
                            detector2 = false;
                            detector1 = false;
                            e1=0;
                            e2=0;
                            e=0;
                            detector3 = true;
                        }
                       
                    }

                    if(detector3 == true)
                    {
                            rY=5; 
                            e2++;
                            detector2 = false;
                            detector1 = false;
                            detector3 = false;
                            e2=0;
                            e1=0;
                            e=0;
                            base3 = true;
                            maxStairsSizeUp = Random.Range(1,3);
                            maxStairsSizeDown = Random.Range(1,3);
                            if(maxStairsSizeUp == 1) {maxStairsSizeUp = 0;}
                            if(maxStairsSizeUp == 2) {maxStairsSizeUp = 2;}
                            //if(maxStairsSizeUp == 3) {maxStairsSizeUp = 4;}
                            if(maxStairsSizeDown == 1) {maxStairsSizeDown = 0;}
                            if(maxStairsSizeDown == 2) {maxStairsSizeDown = 2;}
                            //if(maxStairsSizeDown == 3) {maxStairsSizeDown = 4;}
                    }

                    if(y[j-1] >= 70)
                    {
                        rY = 3;
                    }
                    if(y[j-1] <= 40)
                    {
                        rY = 1;
                    }

                    if(rY == 0 || rY == 1)
                    {
                        y[j] = y[j-1] += 1;
                        detector1 = true;
                        detector2 = false;
                        detector3 = false;
                        light20++;
                        detector3Altar = false;
                    }
                    if(rY == 2 || rY == 3)
                    {
                        y[j] = y[j-1] -= 1;
                        detector2 = true;
                        detector3 = false;
                        detector1 = false;
                        light20++;
                        detector3Altar = false;
                    }
                    if(rY >= 4)
                    {
                        y[j] = y[j-1];
                        light20 += 7;
                        base3 = true;
                        detector3Altar = true;
                    }

                    
                    //light;
                    if(light20 >= 20)
                    {
                        //Vector3 position1 = new Vector3(x, y[j] + 10 , z);
                        //Quaternion rotation1 = new Quaternion();
                        //Instantiate(lightPrefab, position1, rotation1);
                        //light20 = 0;
                    }

                if(base3 == true)
                {
                    if(evil == 2 || evil == 3)
                    {
                        howMuchEnemys2 = Random.Range(howManyMobsS, howManyMobs);

                        if(howMuchEnemys2 == 1)                            { howMuchEnemys = 5;}
                        if(howMuchEnemys2 == 2 || howMuchEnemys2 == 3 )    { howMuchEnemys = 4;}
                        if(howMuchEnemys2 >= 4 && howMuchEnemys2 <= 8 )    { howMuchEnemys = 3;}
                        if(howMuchEnemys2 >= 9 && howMuchEnemys2 <= 16)    { howMuchEnemys = 2;}
                        if(howMuchEnemys2 == 17)                           { howMuchEnemys = 1;}
//                        Debug.Log(howManyMobsS + " , " + howManyMobs + " , " + howMuchEnemys + " , " + primer  + " , " + howMuchEnemys2);
                        for(int k = 0; k < howMuchEnemys; k++)
                        {   
                            if(howMuchEnemys > 1)
                            {
                                int j = 0;
                                if(j == 0)
                                {
                                    z -= 2;
                                    j++;
                                }
                                z += 2;
                            }

                            
                            chooseEnemy = Random.Range(2,whithEvilMax);
                            if(chooseEnemy >= 2 && chooseEnemy <= 6 )
                            {
                                Vector3 position3 = new Vector3(x, y[j] + 2, z );
                                Quaternion rotation3 = new Quaternion(0,0,0,0);
                                Instantiate(evilChaPrefabMetra, position3, rotation3);
                                howMuchEvil01++;
                            }
                            if(chooseEnemy >= 7 && chooseEnemy <= 11)
                            {
                                Vector3 position3 = new Vector3(x, y[j] + 2, z );
                                Quaternion rotation3 = new Quaternion(0,0,0,0);
                                Instantiate(evilChaPrefabTank, position3, rotation3);
                                howMuchEvil02++;
                            }
                            if(chooseEnemy >= 12 && chooseEnemy <= 19)
                            {
                                Vector3 position3 = new Vector3(x, y[j] + 2, z );
                                Quaternion rotation3 = new Quaternion(0,0,0,0);
                                Instantiate(evilChaPrefabArcher, position3, rotation3);
                                howMuchEvil03++;
                            }
                            if(chooseEnemy >= 20 && chooseEnemy <= 24)
                            {
                                Vector3 position05 = new Vector3(x, y[j] + 4, z );
                                Quaternion rotation05 = new Quaternion(0,0,0,0);
                                Instantiate(evilChaPrefab05, position05, rotation05);
                                howMuchEvil04++;
                            }
                            if(chooseEnemy >= 25 && chooseEnemy <= 30)
                            {
                                Vector3 position04 = new Vector3(x, y[j] + 2, z );
                                Quaternion rotation04 = new Quaternion(0,0,0,0);
                                Instantiate(evilChaPrefab04, position04, rotation04);
                                howMuchEvil05++;
                            }

                            
                        }

// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------------------------------------------------




                        z = 47;

                    Vector3 position4 = new Vector3(x, y[j] - 0.5f, z - 2.5f);
                    Quaternion rotation4 = new Quaternion(0,0,0,0);
                    Instantiate(torch, position4, rotation4);
                    Vector3 position5 = new Vector3(x, y[j] -0.5f, z  + 8.5f);
                    Quaternion rotation5 = new Quaternion(0,0,0,0);
                    Instantiate(torch, position5, rotation5);
                    evil = 0;


                    if(primer == 3)
                    {
                        Debug.Log("Fase 1");
                        int tramp1 = Random.Range(0,4);
                        if(tramp1 == 2)
                        {
                            Vector3 a = new Vector3(x, y[j] + 1f, z);
                            Quaternion b = Quaternion.Euler(0,0,0);
                            Instantiate(tramp01, a, b);
                            
                            Vector3 aa = new Vector3(x + 2, y[j] + 1f, z);
                            Instantiate(tramp01, aa, b);

                            Vector3 sss = new Vector3(x  + 2, y[j] + 2f, z);
                            Instantiate(tramp01, sss, b);

                            Vector3 aaaaaa = new Vector3(x, y[j] + 2f, z);
                            Instantiate(tramp01, aaaaaa, b);
                        }
                        Debug.Log("Fase 2 " + tramp1);
                    }
                    if(primer == 4)
                    {
                        int tramp1 = Random.Range(0,3);
                        if(tramp1 == 2)
                        {
                            Quaternion d = Quaternion.Euler(0,0,0);
                            
                            Vector3 ccc = new Vector3(x + 4, y[j] + 1f, z);
                            Instantiate(tramp01, ccc, d);
                            
                            Vector3 cccc = new Vector3(x - 2, y[j] + 1f, z);
                            Instantiate(tramp01, cccc, d);
                            
                            Vector3 cccccc = new Vector3(x + 4, y[j] + 2f, z);
                            Instantiate(tramp01, cccccc, d);
                            
                            Vector3 ccccccc = new Vector3(x - 2, y[j] + 2f, z);
                            Instantiate(tramp01, ccccccc, d);
                            

                        }
                    }
                    if(primer == 5)
                    {
                        int tramp1 = Random.Range(0,2);
                        if(tramp1 == 1)
                        {
                            Vector3 f = new Vector3(x, y[j] + 1f, z);
                            Quaternion g = Quaternion.Euler(0,0,0);
                            Instantiate(tramp01, f, g);
                            
                            Vector3 ff = new Vector3(x + 2, y[j] + 1f, z);
                            Instantiate(tramp01, ff, g);
                            
                            Vector3 fff = new Vector3(x + 4, y[j] + 1f, z);
                            Instantiate(tramp01, fff, g);

                            Vector3 fffff = new Vector3(x  + 2, y[j] + 2f, z);
                            Instantiate(tramp01, fffff, g);
                            
                            Vector3 ffffff = new Vector3(x + 4, y[j] + 2f, z);
                            Instantiate(tramp01, ffffff, g);
                            
                            Vector3 ffffffff = new Vector3(x, y[j] + 2f, z);
                            Instantiate(tramp01, ffffffff, g);
                            
                        }
                    }

                    }
                    else
                    {
                            evil += 1;
                    }

//                print("primer " + primer);

                    if (primer == 2)
                    {
                        diferentBases = Random.Range(6, 15);
                    }
                    if (primer == 3)
                    {
                        diferentBases = Random.Range(4, 10);
                    }
                    if(primer == 4)
                    {
                        diferentBases = Random.Range(2, 8);
                    }
                    if(primer == 5)
                    {
                        diferentBases = Random.Range(1, 5);
                    }

                if(lastBase == diferentBases)
                {
                    diferentBases++;
                }

                lastBase = diferentBases;


                if(baseYesNO)
                {
                    baseYesNO = false;

                    if (diferentBases <= 6 && altarCounter <= altar - 3 && altar > 3)
                    {

                        print("altarCounter " + altarCounter);
                        print("altar " + altar);
                        baseSet++;
                        switch (diferentBases)
                        {
                            case 1:
                                Vector3 position1 = new Vector3(x, y[j], z);
                                Quaternion rotation1 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab1, position1, rotation1);
                                break;
                            case 2:
                                Vector3 position2 = new Vector3(x, y[j], z);
                                Quaternion rotation2 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab2, position2, rotation2);
                                break;
                            case 3:
                                Vector3 position3 = new Vector3(x, y[j], z);
                                Quaternion rotation3 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab3, position3, rotation3);
                                break;
                            case 4:
                                Vector3 position4 = new Vector3(x, y[j], z);
                                Quaternion rotation4 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab4, position4, rotation4);
                                break;
                            case 5:
                                Vector3 position5 = new Vector3(x, y[j], z);
                                Quaternion rotation5 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab5, position5, rotation5);
                                break;
                            case 6:
                                Vector3 position6 = new Vector3(x, y[j], z);
                                Quaternion rotation6 = new Quaternion(0, 0, 0, 0);
                                Instantiate(block3Prefab6, position6, rotation6);
                                break;
                        }
                    }
                    else
                    {
                        baseSet++;
                        Vector3 position = new Vector3(x, y[j], z);
                        Quaternion rotation = new Quaternion(0, 0, 0, 0);
                        Instantiate(block3Prefab, position, rotation);
                    }
                }
                else
                {
                    baseYesNO = true;
                    baseSet++;
                    Vector3 positione = new Vector3(x, y[j], z);
                    Quaternion rotatione = new Quaternion(0, 0, 0, 0);
                    Instantiate(block3Prefab, positione, rotatione);
                }

                
                    

                    /*desertX[0] = 100;
                    desertY[0] = 100;*/
                    specialHMD++;
                    if(altarCounter <= altar - 3 && altarCounter > 2)
                    { 
                        hmD = Random.Range(-1,4);
                        for(int r = 1; r < hmD + 1; r++)
                        {
                            
                            rCS = r;
                            rl = Random.Range(0,2);

                            if(rl == 0)
                            {
                                for(int c = 0; c < 1; c++)
                                {
                                    xD = Random.Range(-25,1);
                                    yD = Random.Range(-55,1);

                                    for(; rCS >= 1 ; rCS--)
                                    {
                                        if(xD >= desertX[rCS] - 20 || xD <= desertX[rCS] + 20)
                                        {
                                            c = 0;
                                        //    Debug.Log("Posicion Ocupada " + r + " , " + specialHMD);
                                        }
                                        if(yD >= desertY[rCS] - 20 || yD <= desertY[rCS] + 20)
                                        {
                                            c = 0;
//                                            Debug.Log("Posicion Ocupada " + r + " , " + specialHMD);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for(int c = 0; c < 1; c++)
                                {
                                    xD = Random.Range(1,26);
                                    yD = Random.Range(1,56);

                                    for(; rCS >= 1 ; rCS--)
                                    {
                                        desertX[rCS] = xD;
                                        desertY[rCS] = yD;
                                        if(xD >= desertX[rCS] - 10 || xD <= desertX[rCS] + 10)
                                        {
                                            c = 0;
                               //             Debug.Log("Posicion Ocupada " + r + " , " + specialHMD);
                                        }
                                        if(yD >= desertY[rCS] - 10 || yD <= desertY[rCS] + 10)
                                        {
                                            c = 0;
                        //                    Debug.Log("Posicion Ocupada " + r + " , " + specialHMD);
                                        }
                                    }
                                }
                            }
                            
                            xD /= 10;
                            yD /= 10;

                            Mathf.Round(xD);
                            Mathf.Round(yD);

                            desertX[r] = xD;
                            desertY[r] = yD;
                            
                            specialWD++;
                            
                            if(randomDesert == false)
                            {
                                if(specialWD <= 5)
                                {
                                    wD = Random.Range(1,6);
                                }
                                else
                                {
                                    wD = Random.Range(1,11);
                                    specialWD = 0;
                                }

                                //Debug.Log("randomDesert = false;");
                            }
                            else
                            {
                                if(randomDP <= 0)
                                {
                                    randomDesert = false;
                                    hmD++;
                                }
                                else
                                {
                                    randomDP -= 1;
                                    //hmD++;
                                }
                            }

                            switch(wD)
                            {
                                case 1:
                                    Vector3 positionl1 = new Vector3(x - xD, y[j] + 1, z + yD);
                                    rot = Random.Range(1,9);
                                    if(p1 == false)
                                    {
                                        randomDesert = true;
                                        randomDP = Random.Range(1,4);
                                        p1 = true;
                                    }
                                    p2 = false;
                                    
                                    wD = 1;
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert1, positionl1, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert1, positionl1, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert1, positionl1, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert1, positionl1, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert1, positionl1, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert1, positionl1, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert1, positionl1, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert1, positionl1, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 2:
                                    Vector3 positionl2 = new Vector3(x + xD, y[j] + 1, z - yD);
                                    rot = Random.Range(1,9);
                                    if(p2 == false)
                                    {
                                        randomDesert = true;
                                        randomDP = Random.Range(1,4);
                                        p2 = true;
                                    }
                                    p1 = false;
                                    wD = 2;
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert2, positionl2, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert2, positionl2, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert2, positionl2, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert2, positionl2, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert2, positionl2, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert2, positionl2, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert2, positionl2, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert2, positionl2, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 3:
                                    Vector3 positionl3 = new Vector3(x - xD, y[j] + 0.7f, z - yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert3, positionl3, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert3, positionl3, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert3, positionl3, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert3, positionl3, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert3, positionl3, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert3, positionl3, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert3, positionl3, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert3, positionl3, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 4:
                                    Vector3 positionl4 = new Vector3(x + xD, y[j] + 0.5f, z + yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert4, positionl4, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert4, positionl4, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert4, positionl4, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert4, positionl4, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert4, positionl4, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert4, positionl4, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert4, positionl4, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert4, positionl4, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 5:
                                    Vector3 positionl5 = new Vector3(x + xD, y[j] + 1, z + yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert5, positionl5, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert5, positionl5, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert5, positionl5, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert5, positionl5, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert5, positionl5, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert5, positionl5, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert5, positionl5, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert5, positionl5, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 6:
                                    Vector3 positionl6 = new Vector3(x - xD, y[j] + 1, z + yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desertS1, positionl6, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desertS1, positionl6, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desertS1, positionl6, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desertS1, positionl6, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desertS1, positionl6, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desertS1, positionl6, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desertS1, positionl6, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desertS1, positionl6, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 7:
                                    Vector3 positionl7 = new Vector3(x + xD, y[j] + 1, z - yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desert2, positionl7, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desert2, positionl7, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desert2, positionl7, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desert2, positionl7, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desert2, positionl7, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desert2, positionl7, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desert2, positionl7, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desert2, positionl7, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 8:
                                    Vector3 positionl8 = new Vector3(x - xD, y[j] + 0.7f, z - yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desertS3, positionl8, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desertS3, positionl8, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desertS3, positionl8, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desertS3, positionl8, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desertS3, positionl8, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desertS3, positionl8, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desertS3, positionl8, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desertS3, positionl8, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 9:
                                    Vector3 positionl9 = new Vector3(x + xD, y[j] + 1, z + yD);
                                    rot = Random.Range(1,9);
                                    switch(rot)
                                    {
                                        case 1: Instantiate(desertS4, positionl9, rot1.transform.rotation);
                                        break;
                                        case 2: Instantiate(desertS4, positionl9, rot2.transform.rotation); 
                                        break;
                                        case 3: Instantiate(desertS4, positionl9, rot3.transform.rotation);
                                        break;
                                        case 4: Instantiate(desertS4, positionl9, rot4.transform.rotation);
                                        break;
                                        case 5: Instantiate(desertS4, positionl9, rot5.transform.rotation);
                                        break;
                                        case 6: Instantiate(desertS4, positionl9, rot6.transform.rotation);
                                        break;
                                        case 7: Instantiate(desertS4, positionl9, rot7.transform.rotation);
                                        break;
                                        case 8: Instantiate(desertS4, positionl9, rot8.transform.rotation);
                                        break;
                                    }
                                break;
                                case 10:
                                        Vector3 positionl10 = new Vector3(x + xD, y[j] + 1, z + yD);
                                        rot = Random.Range(1,9);
                                        switch(rot)
                                        {
                                            case 1: Instantiate(desertS5, positionl10, rot1.transform.rotation);
                                            break;
                                            case 2: Instantiate(desertS5, positionl10, rot2.transform.rotation); 
                                            break;
                                            case 3: Instantiate(desertS5, positionl10, rot3.transform.rotation);
                                            break;
                                            case 4: Instantiate(desertS5, positionl10, rot4.transform.rotation);
                                            break;
                                            case 5: Instantiate(desertS5, positionl10, rot5.transform.rotation);
                                            break;
                                            case 6: Instantiate(desertS5, positionl10, rot6.transform.rotation);
                                            break;
                                            case 7: Instantiate(desertS5, positionl10, rot7.transform.rotation);
                                            break;
                                            case 8: Instantiate(desertS5, positionl10, rot8.transform.rotation);
                                            break;
                                        }
                                break;
                            }
                        }
                    }
                    else
                    {
//                        Debug.Log("Else");
                    }

                    base3 = false;
                    x+=8;
                    pCCS += 7;
                }
                else
                {
                    if(b1)
                    {
                        Vector3 position = new Vector3(x -3.5f, y[j], z);
                        Quaternion rotation = new Quaternion(0,0,0,0);
                        Instantiate(block1Prefab, position, rotation);
                        ++x;
                        b1 = false;
                        //Debug.Log("2");
                    }
                    else
                    {
                        Vector3 position = new Vector3(x-3.5f, y[j], z);
                        Quaternion rotation = new Quaternion(0,0,0,0);
                        Instantiate(block2Prefab, position, rotation);
                        b1 = true;
                        //Debug.Log("3");
                        ++x;
                    }
                }
            altarCounter++;
            j++;
            pCCS++;
            //Debug.Log(pCX + " PCX2 " + pCCS);
           // Debug.Log(" - - - - - - - - ");
        }
    }
            
}

        
    
