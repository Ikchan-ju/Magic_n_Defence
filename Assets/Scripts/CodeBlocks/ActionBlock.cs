using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBlock : CodeBlock, IElementBlock
{
    public override float GoForward()
    {
        return multiple;
    }
}
