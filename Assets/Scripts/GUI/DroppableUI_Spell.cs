using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Spell : DroppableUI
{
    private static List<ICodeBlock> codeBlocks = new List<ICodeBlock>();
    private Transform droppedTransform;
    public override void OnDrop(PointerEventData eventData){
                droppedTransform = eventData.pointerDrag.transform;
        print("Drop");
        if(eventData.pointerDrag == null)
            return;
        if(droppedTransform.GetComponent<ClassBlock>() != null)
        {
            print("this is ClassBlock");
            PutOn(eventData);
            codeBlocks.Add(droppedTransform.GetComponent<ClassBlock>());
        }
        if(droppedTransform.GetComponent<LoopBlock>() != null)
        {
            print("this is LoopBlock");
            PutOn(eventData);
            codeBlocks.Add(droppedTransform.GetComponent<LoopBlock>());
        }

        if(droppedTransform.GetComponent<CodeBlock>() != null)
        {
            print("this is CodeBlock");
            PutOn(eventData);
            codeBlocks.Add(droppedTransform.GetComponent<CodeBlock>());
        }
    }
}
