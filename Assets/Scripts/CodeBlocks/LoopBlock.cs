using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
