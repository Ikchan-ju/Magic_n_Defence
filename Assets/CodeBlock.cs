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
    float GoForward()
    {
        
    }
}
public interface ICodeBlock{
    public float GoForward();
}
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
        advantageTable = new Dictionary<Elemental, Dictionary<Elemental, bool>>();
        var label = File.ReadLines("AdavantageTable.csv").Where(line => line.Split(',')[0] == "AdvantageTable");
        var dict = File.ReadLines("AdavantageTable.csv").Where(line => line.Split(',')[0] != "AdvantageTable").Select((line, i) => line.Split(',').ToDictionary(key => label.ElementAt(i), str => str));
        foreach(var dic in dict){
            try{
                advantageTable[(Elemental)Enum.Parse(typeof(Elemental), dic["AdvantageTable"])] = dic.Where(pair => pair.Key != "AdvantageTable").ToDictionary(pair => (Elemental)Enum.Parse(typeof(Elemental), pair.Key), pair => pair.Value == "1");
            }catch(ArgumentException){
                Console.WriteLine("there is an error at ElementalBlock class");
            }
        }
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
                if(advantageTable[elemental][reference.elemental])
                    return true;
                break;
            case Condition.Description.weak:
                if(advantageTable[reference.elemental][elemental])
                    return true;
                break;
        }
        return false;
    }
}

public class LoopBlock : CodeBlock
{
    public enum Type{
        For, While,
    }
    public Type type;
    public int cap;
    public int count;
    public bool condition;
    float GoForward()
    {
        return multiple;
    }
    void Loop(){
        switch(type){
            case Type.For:
                if(count < cap){
                    count++;
                    GoTo();
                }
                return;
            case Type.While:
                if(condition){
                    GoTo();
                }
                return;
        }
    }
    void GoTo(){

    }
}

public class ClassBlock : CodeBlock
{
    float GoForward()
    {
        return multiple;
    }
}

public class ActionBlock : CodeBlock
{
    float GoForward()
    {
        return multiple;
    }
}