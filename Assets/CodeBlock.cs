using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

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

public class Condition
{
    public bool isTrue = false;

    public enum Description{
        larger, smaller, equal, // (Where T:NumBlock) Each larger & smaller cases contain equal case. Equal case is a special one which can amplitude input source.
         strong, weak, // (where T: ElementalBlock) These cases are judged by the scenario that Tinput attacks Treference.
    }

    public Description description;

    public void Estimate(NumBlock input, NumBlock reference)
    {
        isTrue = input.Comparison(reference);
    }
    public void Estimate(ElementalBlock input, ElementalBlock reference)
    {
        isTrue = input.Comparison(reference);
    }
}
public class NumBlock
{
    float number;
    public Condition.Description description;

    public bool Comparison(NumBlock reference){
        switch(description){
            case Condition.Description.larger:
                if(number >= reference.number)
                    return true;
                break;
            case Condition.Description.smaller:
                if(number <= reference.number)
                    return true;
                break;
            case Condition.Description.equal:
                if(number == reference.number)
                    return true;
                break;
        }
        return false;
    }
}

public class ElementalBlock
{
    ElementalBlock(){
        // advantageTable = new Dictionary<Elemental, Dictionary<Elemental, bool>>();
        // Dictionary<Elemental, bool> tempDict = new Dictionary<Elemental, bool>();
        // tempDict.Add(Elemental.Fire, false);
        // var file = File.ReadLines("AdavantageTable.csv");
        // file.GetEnumerator().MoveNext();
        // var label = file.GetEnumerator.Current.Split(',');
        // var Dict = file.Select(line => line.Split(',')).ToDictionary(line => line[0], line => line.Select(str => str =="0" ? false : true));
        var label = File.ReadLines("AdavantageTable.csv").Where(line => line.Split(',')[0] == "AdvantageTable");
        var dict = File.ReadLines("AdavantageTable.csv").Where(line => line.Split(',')[0] != "AdvantageTable").Select(line, i => line.Split(',').ToDictionary(key => label[i], str => str));
    }
    public Condition.Description description = Condition.Description.strong;
    public Elemental elemental;
    public enum Elemental{
        Fire, Water, Wind, Earth, Wood, Electric, Light, Darkness, Evil, Saint,
    }
    public Dictionary<Elemental, Dictionary<Elemental, bool>> advantageTable;
    public bool IsStrong(Elemental input, Elemental reference){
        return false;
    }
    public bool Comparison(ElementalBlock reference){
        switch(description){
            case Condition.Description.strong:
                if(elemental >= reference.elemental)
                    return true;
                break;
            case Condition.Description.weak:
                if(elemental <= reference.elemental)
                    return true;
                break;
        }
        return false;
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