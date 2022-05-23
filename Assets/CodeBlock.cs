using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlock : MonoBehaviour
{
    // This Class is a parent class of every code parts
    // i.e. if, num, elemental, loop, class, ...
    // Start is called before the first frame update
    public string name;
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
    public Condition condition;
    int Action()
    {
        if(condition.isTrue)
            multiple *= 1;
        else
            multiple *= 0;
        return (int) multiple;
    }
}

public class Condition<T>
{
    public bool isTrue = false;

    public enum Description{
        larger, smaller, equal, strong, weak, 
    }

    public Description description;

    public void Estimate(T input, T input2)
    {
        switch(description){
            case Description.larger:
                break;

            case Description.smaller:
                break;

            case Description.equal:
                break;

            case Description.strong:
                break;

            case Description.weak:
                break;
                
            default:
                break;
        }
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