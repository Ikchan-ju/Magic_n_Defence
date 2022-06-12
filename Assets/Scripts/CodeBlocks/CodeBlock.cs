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
    public virtual float GoForward()
    {
        return multiple;
    }
}