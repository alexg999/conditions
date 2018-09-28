using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{

    public bool ifbool;
    public int value;

    // Use this for initialization
    void Start()
    {
        if (ifbool == true)
        {
            print("ja");


        }
        else
        {
            print("nej");

        }





    }

    // Update is called once per frame
    void Update()
    {
        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med 
        // <= mindre eller lika med
        // && (shift 6)
        // || eller (altgr <)
        if(Input.GetKeyDown(KeyCode.E))
        {
            value = Random.Range(0, 10);
           
            print("bra gjort...");

        }


        if (value == 5)
        {
            print("tuduloo");
        }

        else if (value == 4)
        {
            print("hai");
        }
        else if (value == 3)

        {
            print("ya boi");
        }
        else
        {
            //print("fan va cringe jag e");
        }
    }
}
