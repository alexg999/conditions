using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgift : MonoBehaviour
{
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public int a;
    public int trianglebase;
    public float angle;
    public float peices;
    public string username;
    public float radius;
    public int damage;
    public int demonHp;
    public int demonAmount;
    public int maxDamage;
    public int minDamage;

    public int DemonHp
    {
        get
        {
            return demonHp;
        }

        set
        {
            demonHp = value;
        }
    }

    void Uppgift1()
    {
        Debug.Log(string.Format("Uppgift 1 {0}", (963 * 421) - (175463/87f)));
    }
    void Uppgift2()
    {

        Debug.Log(string.Format("Uppgift 2 {0}", (sentence1 + sentence2 + sentence3)));


    }
    void Uppgift3()
    {

        Debug.Log(string.Format("uppgift 3 {0} {1}", (Mathf.Pow(a, 2)), Mathf.Sqrt(a)));

   

    }
    void Uppgift4()
    {

        Debug.Log(string.Format("uppgift 4 {0}", (8 * trianglebase) / 2));

    }
    void Uppgift5()
    {

        Debug.Log(string.Format("uppgift 5 {0}", 360 / angle));

        Debug.Log(string.Format("uppgift 5a {0}", 360 / peices));

    }
    void Uppgift6()
    {

        Debug.Log(string.Format("uppgift 6 {0}", "Boss " + username + " Of Doom"));

    }

    void Uppgift7()
    {

        Debug.Log(string.Format("uppgift 7 {0}", 4 * 3.14 *(Mathf.Pow(radius, 3) / 3)));

    }
    void Uppgift8()
    {
        demonHp = demonHp - damage;

        Debug.Log(string.Format("All DemonHP: {0}", demonHp * demonAmount));

    }

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
    }
    


    // Update is called once per frame
    void Update()
    {
        Uppgift8();
        

    }
}
