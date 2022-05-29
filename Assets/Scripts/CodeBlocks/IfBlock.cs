using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfBlock : CodeBlock
{
    public Condition condition;
    float GoForward()
    {
        if(condition.isTrue)
            multiple *= 1;
        else
            multiple *= 0;
        return multiple;
    }
}
