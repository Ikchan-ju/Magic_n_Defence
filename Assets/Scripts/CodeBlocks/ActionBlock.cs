using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBlock : MonoBehaviour, IElementBlock
{
    public virtual void doAction(){
        print("DoAction");
    }
    public virtual void readyAction(float percentage){
        print("ReadyAction");
        print((int)(percentage*100) + "% Completed!");
    }
}
