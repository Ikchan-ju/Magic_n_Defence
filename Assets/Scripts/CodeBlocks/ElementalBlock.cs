using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;

public class AttributionBlock : MonoBehaviour, IElementBlock
{
    AttributionBlock(){
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
    public static Dictionary<Elemental, Dictionary<Elemental, bool>> advantageTable;
    public bool IsStrong(Elemental input, Elemental reference){
        return false;
    }
    public bool Comparison(AttributionBlock reference){
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