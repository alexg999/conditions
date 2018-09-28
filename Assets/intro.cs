using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{   // public = syns i unity
    // int = heltal
    // hejdå = namnet
    public int hejdå;
    // float = decimaltal med 7 precision.
    public float george;

    // double = decimaltal med 15 precision.
    public double bush;

    // string = text 
    public string minecraft;

    // bool = någpt som är true/false (ja/nej)

    public bool john;



    /* multi line comment 
     * lååååååååååå
     * lååååååååååå
     * lååååååååååå
     * lååååååååååång ass kommentar
     */



    //char = ett tecken.
    public char dennis;
    // Use this for initialization
    void Start()
    {

        PrintText();

    }

    void PrintText()
    {

        Debug.Log(minecraft);
        Debug.Log(hejdå + george);
        Calculate();
        //Debug.LogError(
        //    Mathf.Sqrt(54873) +
        //    Mathf.Sqrt(54873));

    }

    // Update is called once per frame
    void Update()
    {


    }
    void Calculate()
    {

        Debug.Log(5 + 5);
        Debug.Log(13 / 7f);
    }

}

