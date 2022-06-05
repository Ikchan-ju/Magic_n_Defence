using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumBlock : MonoBehaviour, IElementBlock
{
    // Start is called before the first frame update
    private Text text;
    public float number;
    public virtual void Start()
    {
        text = GetComponentInChildren<Text>();
        text.text = ((int)number).ToString();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if((int)number != Int32.Parse(text.text)){
            text.text = ((int)number).ToString();
        }
    }

    public static bool operator ==(NumBlock input, NumBlock refer){
        return input?.number == refer?.number;
    }
    // override object.Equals
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        
        return base.Equals (obj);
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        return base.GetHashCode();
    }
    public static bool operator !=(NumBlock input, NumBlock refer){
        return input?.number != refer?.number;
    }
    public static bool operator >=(NumBlock input, NumBlock refer){
        return input?.number >= refer?.number;
    }
    public static bool operator <=(NumBlock input, NumBlock refer){
        return input?.number <= refer?.number;
    }
    public static bool operator >(NumBlock input, NumBlock refer){
        return input?.number > refer?.number;
    }
    public static bool operator <(NumBlock input, NumBlock refer){
        return input?.number < refer?.number;
    }
}

