using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfBlock : CodeBlock, IElementBlock
{
    public enum Condition{
        Num_Larger, Num_Smaller, Num_Equal,
        Attr_Attack, Attr_Defense,
    }
    public Condition condition;
    public new IElementBlock input;
    public IElementBlock reference;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public override float GoForward()
    {
        if(IsTrue())
            multiple *= 1;
        else
            multiple *= 0;
        return multiple;
    }
    public bool IsTrue(){
        return true;
    }
}
