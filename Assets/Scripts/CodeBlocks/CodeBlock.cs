using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public class CodeBlock : MonoBehaviour, ICodeBlock
{
    public float multiple = 1;
    public float source;
    public float input;
    float input_backup;
    public float output;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(input != input_backup)
            output = input * multiple;
        input_backup = input;
    }
    public virtual float GoForward()
    {
        return multiple;
    }
}