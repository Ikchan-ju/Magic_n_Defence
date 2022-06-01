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
        }else if(eventData.clickCount  == 2){
            print("Double Click");
        }
    }

}
