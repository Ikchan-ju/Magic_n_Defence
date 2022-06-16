using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Code : DroppableUI
{
    private static List<IElementBlock> elementBlocks = new List<IElementBlock>();
    // public static ManaInputBlock manaInput;
    // public static LogicalOperatorBlock logicalOperatorBlock;
    // public static NumBlock referenceNum;
    // public static ActionBlock actionBlock;
    // public static ClassBlock classBlock;
    public static GameObject manaInputBlock;
    public static GameObject logicalOperatorBlock;
    public static GameObject referenceNumBlock;
    public static GameObject actionBlock;
    public static ClassBlock classBlock;
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
        if(droppedTransform.GetComponent<AttributionBlock>() != null)
        {
            print("this is ElementalBlock");
            elementBlocks.Add(droppedTransform.GetComponent<AttributionBlock>());
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
                if(droppedTransform.GetComponent<ManaInputBlock>() == null)
                    break;
                manaInputBlock = droppedTransform.gameObject;
                PutOn(eventData);
                break;
            case "IfSlot_LogicalOperator":
                if(droppedTransform.GetComponent<LogicalOperatorBlock>() == null)
                    break;
                logicalOperatorBlock = droppedTransform.gameObject;
                PutOn(eventData);
                break;
            case "IfSlot_ReferenceNum":
                if(droppedTransform.GetComponent<NumBlock>() == null)
                    break;
                referenceNumBlock = droppedTransform.gameObject;
                PutOn(eventData);
                break;
            case "IfSlot_Action":
                if(droppedTransform.GetComponent<ActionBlock>() == null)
                    break;
                actionBlock = droppedTransform.gameObject;
                PutOn(eventData);
                break;
        }
    }
    public static void ResetElement(){
        // manaInput = null;
        // logicalOperatorBlock = null;
        // referenceNum = null;
        // actionBlock = null;
        // classBlock = null;
        manaInputBlock.SetActive(false);
        logicalOperatorBlock.SetActive(false);
        referenceNumBlock.SetActive(false);
        actionBlock.SetActive(false);
        classBlock = null;
    }
    public override void OnPointerExit(PointerEventData eventData){
        SetTransparency(Color.white, 1.0f);
    }
    private void Update() {
        if(manaInputBlock == null || logicalOperatorBlock == null || referenceNumBlock == null || actionBlock == null)
            return;
        if(classBlock == null){
            classBlock = new ClassBlock(manaInputBlock, logicalOperatorBlock, referenceNumBlock, actionBlock);
        }
        classBlock.GoForward();
        //print("The condition (" + manaInput.number.ToString() + logicalOperatorBlock.logicalOperator.ToString() + referenceNum.number.ToString() + ") is " + classBlock.getCondition().ToString() + (classBlock.getCondition() ? ". Do Action" : "."));
    }
}
