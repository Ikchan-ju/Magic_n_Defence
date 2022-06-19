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
    public GameObject manaInputObject;
    public GameObject logicalOperatorObject;
    public GameObject referenceNumObject;
    public GameObject actionObject;

    public ClassBlock(GameObject manaInputBlock, GameObject logicalOperatorBlock, GameObject referenceNumBlock, GameObject actionBlock){
        Init(manaInputBlock, logicalOperatorBlock, referenceNumBlock, actionBlock);
    }
    public void Init(GameObject manaInputBlock, GameObject logicalOperatorBlock, GameObject referenceNumBlock, GameObject actionBlock){
        this.manaInputObject = manaInputBlock;
        this.logicalOperatorObject = logicalOperatorBlock;
        this.referenceNumObject = referenceNumBlock;
        this.actionObject = actionBlock;
        this.mode = Mode.LogicalOperation;
    }
    public void Backup(GameObject manaInputBlock, GameObject logicalOperatorBlock, GameObject referenceNumBlock, GameObject actionBlock){
        this.manaInputObject = manaInputBlock;
        this.logicalOperatorObject = logicalOperatorBlock;
        this.referenceNumObject = referenceNumBlock;
        this.actionObject = actionBlock;
    }
    public override float GoForward()
    {
        if(mode == Mode.LogicalOperation){
            if(getCondition()){
                actionObject?.GetComponent<ActionBlock>().doAction();
            }
            else if(manaInputObject?.GetComponent<ManaInputBlock>() == null || logicalOperatorObject?.GetComponent<LogicalOperatorBlock>() == null || referenceNumObject?.GetComponent<NumBlock>() == null || actionObject?.GetComponent<ActionBlock>() == null){
                return 0;
            }
            else{
                actionObject?.GetComponent<ActionBlock>().readyAction(manaInputObject?.GetComponent<ManaInputBlock>()/referenceNumObject?.GetComponent<NumBlock>());
            }
        }
        return multiple;
    }
    public bool getCondition(){ // Need to check that this switch-case can be simplified with delegate.
        if(manaInputObject?.GetComponent<ManaInputBlock>() == null || logicalOperatorObject?.GetComponent<LogicalOperatorBlock>() == null || referenceNumObject?.GetComponent<NumBlock>() == null || actionObject?.GetComponent<ActionBlock>() == null)
            return false;
        switch(logicalOperatorObject?.GetComponent<LogicalOperatorBlock>().logicalOperator){ // Every cases contains equality.
            case ">":
                return manaInputObject?.GetComponent<ManaInputBlock>() >= referenceNumObject?.GetComponent<NumBlock>();
            case "=":
                return manaInputObject?.GetComponent<ManaInputBlock>() == referenceNumObject?.GetComponent<NumBlock>();
            case "<":
                return manaInputObject?.GetComponent<ManaInputBlock>() <= referenceNumObject?.GetComponent<NumBlock>();
        }
        return false;
    }
}
