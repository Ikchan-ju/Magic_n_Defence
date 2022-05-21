using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlock : MonoBehaviour
{
    // This Class is a parent class of every code parts
    // i.e. if, num, elemental, loop, class, ...
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Action()
    {

    }
}

public class IfBlock : CodeBlock
{
    void Action(){

    }
}

public class NumBlock : CodeBlock
{
    void Action(){
        
    }
}

public class ElementalBlock : CodeBlock
{
    void Action(){
        
    }
}

public class LoopBlock : CodeBlock
{
    void Action(){
        
    }
}

public class ClassBlock : CodeBlock
{
    void Action(){
        
    }
}