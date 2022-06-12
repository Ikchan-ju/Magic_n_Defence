using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBlock : MonoBehaviour, IElementBlock
{
    // public Sprite image;
    public GameObject action;
    private void Start() {
        print("start");
        GetComponent<Image>().sprite = action.GetComponent<SpriteRenderer>().sprite;
    }
    public virtual void doAction(){
        print("DoAction");
    }
    public virtual void readyAction(float percentage){
        print("ReadyAction");
        print((int)(percentage*100) + "% Completed!");
    }
}
