using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ClassBlock : CodeBlock
{
    public List<ClassBlock> classBlocks;
    public enum Mode{
        LogicalOperation, AttributionSuperiority
    }
    public Mode mode;
    public ManaInputBlock manaInput;
    public LogicalOperatorBlock logicalOperator;
    public NumBlock referenceNum;
    public AttributionBlock attribution;
    public ActionBlock action;

    public ClassBlock(ManaInputBlock manaInputBlock, LogicalOperatorBlock logicalOperatorBlock, NumBlock numBlock, ActionBlock actionBlock){
        Init(manaInputBlock, logicalOperatorBlock, numBlock, actionBlock);
    }
    public void Init(ManaInputBlock manaInputBlock, LogicalOperatorBlock logicalOperatorBlock, NumBlock numBlock, ActionBlock actionBlock){
        this.manaInput = manaInputBlock;
        this.logicalOperator = logicalOperatorBlock;
        this.referenceNum = numBlock;
        this.action = actionBlock;
        this.mode = Mode.LogicalOperation;
    }
    public override float GoForward()
    {
        if(mode == Mode.LogicalOperation){
            if(getCondition()){
                action.doAction();
            }
            else{
                action.readyAction(manaInput/referenceNum);
            }
        }
        return multiple;
    }
    public bool getCondition(){ // Need to check that this switch-case can be simplified with delegate.
        if(manaInput == null || logicalOperator == null || referenceNum == null)
            return false;
        switch(logicalOperator.logicalOperator){ // Every cases contains equality.
            case ">":
                return manaInput >= referenceNum;
            case "=":
                return manaInput == referenceNum;
            case "<":
                return manaInput <= referenceNum;
        }
        return false;
    }
}
