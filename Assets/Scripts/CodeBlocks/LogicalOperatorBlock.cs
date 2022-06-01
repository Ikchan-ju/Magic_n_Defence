using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LogicalOperatorBlock : MonoBehaviour, IElementBlock
{
    // Start is called before the first frame update
    private Text text;
    public string logicalOperator;
    void Start()
    {
        text = GetComponentInChildren<Text>();
        text.text = logicalOperator;
    }

    // Update is called once per frame
    void Update()
    {
        if(logicalOperator != text.text){
            text.text = logicalOperator.ToString();
        }
    }
}
