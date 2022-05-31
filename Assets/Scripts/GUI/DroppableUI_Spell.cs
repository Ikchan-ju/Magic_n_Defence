using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Spell : DroppableUI
{
    private static List<ICodeBlock> codeBlocks;
    public void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag != null){
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }
}
