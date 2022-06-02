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
    private Transform droppedTransform;
    public override void OnDrop(PointerEventData eventData){
        droppedTransform = eventData.pointerDrag.transform;
        print("Drop");
        if(eventData.pointerDrag == null)
            return;
        print("Null check pass");
        print(droppedTransform.name);
        print(droppedTransform.childCount);
        print(droppedTransform.GetChild(0).name);
        print(droppedTransform.GetChild(0).GetType().ToString());
        if(droppedTransform.GetComponent<NumBlock>() != null)
        {
            print("this is NumBlock");
            PutOn(eventData);
            elementBlocks.Add(droppedTransform.GetComponent<NumBlock>());
        }
        if(droppedTransform.GetComponent<ElementalBlock>() != null)
        {
            print("this is ElementalBlock");
            PutOn(eventData);
            elementBlocks.Add(droppedTransform.GetComponent<ElementalBlock>());
        }
        if(droppedTransform.GetComponent<LogicalOperatorBlock>() != null)
        {
            print("this is LogicalOperatorBlock");
            PutOn(eventData);
            elementBlocks.Add(droppedTransform.GetComponent<LogicalOperatorBlock>());
        }
        if(droppedTransform.GetComponent<IfBlock>() != null)
        {
            print("this is IfBlock");
            PutOn(eventData);
            elementBlocks.Add(droppedTransform.GetComponent<IfBlock>());
        }
        if(droppedTransform.GetComponent<IElementBlock>() != null)
        {
            print("this is IElementBlock");
            PutOn(eventData);
            elementBlocks.Add(droppedTransform.GetComponent<IElementBlock>());
        }

        switch(transform.name){
            case "IfSlot_InputNum":
                numBlock_Input = droppedTransform.GetComponent<NumBlock>();
                break;
            case "IfSlot_LogicalOperator":
                logicalOperatorBlock = droppedTransform.GetComponent<LogicalOperatorBlock>();
                break;
            case "IfSlot_ReferenceNum":
                numBlock_Reference = droppedTransform.GetComponent<NumBlock>();
                break;
        }
    }
    private void Update() {
        if(numBlock_Input == null)
            return;
        if(logicalOperatorBlock == null)
            return;
        if(numBlock_Reference == null)
            return;
        print("The condition is " + numBlock_Input.number.ToString() + logicalOperatorBlock.logicalOperator.ToString() + numBlock_Reference.number.ToString());
    }
}
