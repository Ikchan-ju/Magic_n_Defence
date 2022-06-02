using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Code : DroppableUI
{
    private static List<IElementBlock> elementBlocks = new List<IElementBlock>();
    public override void OnDrop(PointerEventData eventData){
        print("Drop");
        if(eventData.pointerDrag == null)
            return;
        if(GetComponent<NumBlock>() != null)
        {
            print("this is NumBlock");
            PutOn(eventData);
            elementBlocks.Add(GetComponent<NumBlock>());
        }
        if(GetComponent<ElementalBlock>() != null)
        {
            print("this is ElementalBlock");
            PutOn(eventData);
            elementBlocks.Add(GetComponent<ElementalBlock>());
        }
        if(GetComponent<LogicalOperatorBlock>() != null)
        {
            print("this is LogicalOperatorBlock");
            PutOn(eventData);
            elementBlocks.Add(GetComponent<LogicalOperatorBlock>());
        }
        if(GetComponent<IfBlock>() != null)
        {
            print("this is IfBlock");
            PutOn(eventData);
            elementBlocks.Add(GetComponent<IfBlock>());
        }

        if(GetComponent<IElementBlock>() != null)
        {
            print("this is IElementBlock");
            PutOn(eventData);
            elementBlocks.Add(GetComponent<IElementBlock>());
        }
    }
}
