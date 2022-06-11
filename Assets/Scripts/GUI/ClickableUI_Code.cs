using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableUI_Code : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData){
        print("click event. clickCount : " + eventData.clickCount + ", clickTime : " + eventData.clickTime);
        if(eventData.clickCount  == 1){
            print("Click");
            
        if(GetComponentInChildren<ClassBlock>() != null)
        {
            var classBlock = GetComponentInChildren<ClassBlock>();
            DroppableUI_Code.classBlock = classBlock;
            DroppableUI_Code.manaInput = classBlock.manaInput;
            DroppableUI_Code.logicalOperatorBlock = classBlock.logicalOperator;
            DroppableUI_Code.referenceNum = classBlock.referenceNum;
            DroppableUI_Code.actionBlock = classBlock.action;
        }
        }else if(eventData.clickCount  == 2){
            print("Double Click");
        }
    }

}
