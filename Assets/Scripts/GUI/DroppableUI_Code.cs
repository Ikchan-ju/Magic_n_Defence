using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Code : DroppableUI
{
    private static List<IElementBlock> elementBlocks = new List<IElementBlock>();
    public void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag == null)
            return;
        if(getComponent<NumBlock>() != null)
        {
            print("this is NumBlock");
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
            elementBlocks.Add(getComponent<NumBlock>());
        }
        if(getComponent<ElementalBlock>() != null)
        {
            print("this is ElementalBlock");
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
            elementBlocks.Add(getComponent<ElementalBlock>());
        }
        if(getComponent<IfBlock>() != null)
        {
            print("this is IfBlock");
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
            elementBlocks.Add(getComponent<IfBlock>());
        }

        if(getComponent<IElementBlock>() != null)
        {
            print("this is IElementBlock");
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
            elementBlocks.Add(getComponent<IElementBlock>());
        }
    }
}
