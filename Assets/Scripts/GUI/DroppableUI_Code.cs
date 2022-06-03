using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Code : DroppableUI
{
    private static List<IElementBlock> elementBlocks = new List<IElementBlock>();
    private static NumBlock numBlock_Input;
    private static LogicalOperatorBlock logicalOperatorBlock;
    private static NumBlock numBlock_Reference;
    private static ActionBlock actionBlock;
    private Transform droppedTransform;
    public override void OnDrop(PointerEventData eventData){
        droppedTransform = eventData.pointerDrag.transform;
        if(eventData.pointerDrag == null)
            return;
        if(droppedTransform.GetComponent<NumBlock>() != null)
        {
            print("this is NumBlock");
            elementBlocks.Add(droppedTransform.GetComponent<NumBlock>());
        }
        if(droppedTransform.GetComponent<ElementalBlock>() != null)
        {
            print("this is ElementalBlock");
            elementBlocks.Add(droppedTransform.GetComponent<ElementalBlock>());
        }
        if(droppedTransform.GetComponent<LogicalOperatorBlock>() != null)
        {
            print("this is LogicalOperatorBlock");
            elementBlocks.Add(droppedTransform.GetComponent<LogicalOperatorBlock>());
        }
        if(droppedTransform.GetComponent<IfBlock>() != null)
        {
            print("this is IfBlock");
            elementBlocks.Add(droppedTransform.GetComponent<IfBlock>());
        }
        if(droppedTransform.GetComponent<ActionBlock>() != null)
        {
            print("this is ActionBlock");
            elementBlocks.Add(droppedTransform.GetComponent<ActionBlock>());
        }
        if(droppedTransform.GetComponent<IElementBlock>() != null)
        {
            print("this is IElementBlock");
            elementBlocks.Add(droppedTransform.GetComponent<IElementBlock>());
        }

        switch(transform.name){
            case "IfSlot_InputNum":
                if(droppedTransform.GetComponent<NumBlock>() == null)
                    break;
                numBlock_Input = droppedTransform.GetComponent<NumBlock>();
                PutOn(eventData);
                break;
            case "IfSlot_LogicalOperator":
                if(droppedTransform.GetComponent<LogicalOperatorBlock>() == null)
                    break;
                logicalOperatorBlock = droppedTransform.GetComponent<LogicalOperatorBlock>();
                PutOn(eventData);
                break;
            case "IfSlot_ReferenceNum":
                if(droppedTransform.GetComponent<NumBlock>() == null)
                    break;
                numBlock_Reference = droppedTransform.GetComponent<NumBlock>();
                PutOn(eventData);
                break;
            case "IfSlot_Action":
                if(droppedTransform.GetComponent<ActionBlock>() == null)
                    break;
                actionBlock = droppedTransform.GetComponent<ActionBlock>();
                PutOn(eventData);
                break;
        }
    }
    public override void OnPointerExit(PointerEventData eventData){
        SetTransparency(Color.white, 1.0f);
    }
    private void Update() {
        if(numBlock_Input == null || logicalOperatorBlock == null || numBlock_Reference == null || actionBlock == null)
            return;
        // if(numBlock_Input == null)
        //     return;
        // if(logicalOperatorBlock == null)
        //     return;
        // if(numBlock_Reference == null)
        //     return;
        // if(actionBlock == null)
        //     return;
        print("The condition (" + numBlock_Input.number.ToString() + logicalOperatorBlock.logicalOperator.ToString() + numBlock_Reference.number.ToString() + ") is " + getCondition().ToString() + (getCondition() ? ". Do Action" : "."));
    }
    private bool getCondition(){ // Need to check that this switch-case can be simplified with delegate.
        if(numBlock_Input == null || logicalOperatorBlock == null || numBlock_Reference == null)
            return false;
        switch(logicalOperatorBlock.logicalOperator){ // Every cases contains equality.
            case ">":
                return numBlock_Input >= numBlock_Reference;
            case "=":
                return numBlock_Input == numBlock_Reference;
            case "<":
                return numBlock_Input <= numBlock_Reference;
        }
        return false;
    }
}
