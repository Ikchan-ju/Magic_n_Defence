using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumBlock : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public float number;
    void Start()
    {
        
        text = GetComponentInChildren<Text>();
        text.text = "11";
    }

    // Update is called once per frame
    void Update()
    {
        // text = GetComponent<Text>();
        if((int)number != Int32.Parse(text.text)){
            text.text = ((int)number).ToString();
        }
    }
    // public string name;
    // public Condition.Description description;

    // public bool Comparison(NumBlock reference){
    //     switch(description){
    //         case Condition.Description.larger:
    //             if(number >= reference.number)
    //                 return true;
    //             break;
    //         case Condition.Description.smaller:
    //             if(number <= reference.number)
    //                 return true;
    //             break;
    //         case Condition.Description.equal:
    //             if(number == reference.number)
    //                 return true;
    //             break;
    //     }
    //     return false;
    // }
}

