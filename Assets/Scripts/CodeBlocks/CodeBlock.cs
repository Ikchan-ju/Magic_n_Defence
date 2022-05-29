using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public class CodeBlock : MonoBehaviour, ICodeBlock
{
    // Start is called before the first frame update
    public string name;
    public float multiple = 1;
    public float source;
    public float input;
    float input_backup;
    public float output;
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
    public float GoForward()
    {
        return multiple;
    }
}
public interface ICodeBlock{
    float GoForward();
}