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
    private ManaInputBlock manaInputBlock;
    private LogicalOperatorBlock logicalOperatorBlock;
    private NumBlock referenceNumBlock;
    private AttributionBlock attribution;
    private ActionBlock actionBlock;
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

        this.manaInputBlock = this.manaInputObject.GetComponent<ManaInputBlock>();
        this.logicalOperatorBlock = this.logicalOperatorObject.GetComponent<LogicalOperatorBlock>();
        this.referenceNumBlock = this.referenceNumObject.GetComponent<NumBlock>();
        this.actionBlock = this.actionObject.GetComponent<ActionBlock>();
    }
    public override float GoForward()
    {
        if(mode == Mode.LogicalOperation){
            if(getCondition()){
                actionBlock.doAction();
            }
            else{
                actionBlock.readyAction(manaInputBlock/referenceNumBlock);
            }
        }
        return multiple;
    }
    public bool getCondition(){ // Need to check that this switch-case can be simplified with delegate.
        if(manaInputBlock == null || logicalOperatorBlock == null || referenceNumBlock == null)
            return false;
        switch(logicalOperatorBlock.logicalOperator){ // Every cases contains equality.
            case ">":
                return manaInputBlock >= referenceNumBlock;
            case "=":
                return manaInputBlock == referenceNumBlock;
            case "<":
                return manaInputBlock <= referenceNumBlock;
        }
        return false;
    }
}
