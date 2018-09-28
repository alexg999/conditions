using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgift1 : MonoBehaviour
{

    public int userValue;
    public int userpoints;
    private int Userpoints = 10;
    private int dragonhealth;
    public int playerhealth = 100;
    private int dragonHitChance;
    private int playerDamage;
    private int dragonDamage;
    private int playerMaxDamage;
    private int playerMinDamage;
    private int dragonMinDamage;
    private int dragonMaxDamage;
    public bool isFighting;
    private int dragonHealthMultiplier;
    private int oldnumber = 50;
    private int newnumber;
    private int score;
    bool startbool = true;
   
    private int highScore;
    // Use this for initialization
    void Start()
    {
        dragonhealth = Random.Range(100, 150);
        print(string.Format(
            "dragon health this round {0}", dragonhealth));
    }

    // Update is called once per frame
    void Update()
    {
        task1();
        task2();
        task3();
        task4();
    }

    void task1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;


        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
    }

    void task2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            userpoints = (userpoints + (Random.Range(1, 7)));
            userpoints = (userpoints - (Random.Range(1, 7)));
            print("värde är " + userpoints);
            if (userpoints >= 20)
            {
                print("du har inget liv men du vann");

            }
            if (userpoints <= 0)
            {
                print("sämst");
            }
        }
    }



    void task3()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isFighting == false)
            {
                playerMinDamage = Random.Range(1, 20);
                playerMaxDamage = Random.Range(20, 30);
                dragonMinDamage = Random.Range(10, 20);
                dragonMaxDamage = Random.Range(20, 40);
                dragonhealth = Random.Range(100, 151);
                playerhealth = 100;
                dragonHealthMultiplier = Random.Range(0, 10);
                if (dragonHealthMultiplier == 0)
                {
                    dragonhealth = dragonhealth * 2;
                    print("draken fick dubbelt så mycket liv, du är fucked");
                }
                isFighting = true;
            }
            if (dragonhealth > 0 && playerhealth > 0)
            {
                dragonDamage = (Random.Range(dragonMinDamage, dragonMaxDamage));
                playerDamage = (Random.Range(playerMinDamage, playerMaxDamage));
                dragonhealth = (dragonhealth - (Random.Range(5, 26)));
                dragonHitChance = Random.Range(0, 2);
                Debug.Log(string.Format("spelaren träffar draken för {0} skada", playerDamage));
                if (dragonHitChance == 1)
                {
                    playerhealth = (playerhealth - (Random.Range(10, 21)));
                    Debug.Log(string.Format("draken träffade för {0} skada", dragonDamage));

                }
                else
                {
                    print("draken missa fö fan");
                }

                Debug.Log(string.Format("spelaren har {0} hp", playerhealth));
                Debug.Log(string.Format("draken har {0} hp", dragonhealth));
                if (playerhealth <= 0)
                {
                    print("du förlora och är sämst");
                    isFighting = false;
                }
                if (dragonhealth <= 0)
                {
                    print("du vann och är helt ok");
                    isFighting = false;
                }
            }


        }

    }

    void task4()
    {
        if (startbool == true)
        {
            Debug.Log(string.Format("är nästa nummer högre eller lägre än {0}", oldnumber));
            newnumber = Random.Range(1, 101);
            startbool = false;
        }
        if (Input.GetKeyDown(KeyCode.Y) && startbool == true)
        {
            if (newnumber > oldnumber)
            {
                score = score + 1;
                Debug.Log(string.Format("du har rätt och din score är {0}", score));
                startbool = true;
                oldnumber = newnumber;
            }
            else 
            {
                Debug.Log(string.Format("du har tyvärr fel och ditt slutgiltiga score hamnade på {0}", score));
                if (score > highScore)
                {
                    highScore = score;
                    Debug.Log(string.Format("woaahhhhh nytt highscore även fast du bara fick {0}", highScore));
                }
                    startbool = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.H) && startbool == true)
        {
            if (newnumber < oldnumber)
            {
                score = score + 1;
                Debug.Log(string.Format("du har rätt och din score är {0}", score));
                startbool = true;
                oldnumber = newnumber;
                
            }
            else
            {
                Debug.Log(string.Format("du har tyvärr fel och ditt slutgiltiga score hamnade på {0}", score));
                if (score > highScore)
                {
                    highScore = score;
                    Debug.Log(string.Format("woaahhhhh nytt highscore även fast du bara fick {0}", highScore));
                    startbool = false;
                }
                
                       
                
            }
        }
    }
}