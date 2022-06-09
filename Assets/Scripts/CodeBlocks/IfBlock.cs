using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfBlock : MonoBehaviour, IElementBlock
{
    public enum Condition{
        Num_Larger, Num_Smaller, Num_Equal,
        Attr_Attack, Attr_Defense,
    }
    public Condition condition;
    public IElementBlock input;
    public IElementBlock reference;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public bool IsTrue(){
        return true;
    }
}
