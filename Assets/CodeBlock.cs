using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlock : MonoBehaviour
{
    // This Class is a parent class of every code parts
    // i.e. if, num, elemental, loop, class, ...
    // Start is called before the first frame update
    public double multiple = 1;
    public double source;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int damage = (int) (source * multiple);
    }

    int Action()
    {
        return (int) multiple;
    }
}

public class IfBlock : CodeBlock
{
    public bool condition;
    int Action()
    {
        if(condition)
            multiple *= 1;
        else
            multiple *= 0;
        return (int) multiple;
    }
}

public class NumBlock : CodeBlock
{
    int Action()
    {
        return (int) multiple;
    }
}

public class ElementalBlock : CodeBlock
{
    public Elemental elemental;
    public enum Elemental{
        Fire, Water, Wind, Earth, Wood, Electric, Light, Darkness, Evil, Saint,
    }
    int Action()
    {
        return (int) multiple;
    }
}

public class LoopBlock : CodeBlock
{
    int Action()
    {
        return (int) multiple;
    }
}

public class ClassBlock : CodeBlock
{
    int Action()
    {
        return (int) multiple;
    }
}