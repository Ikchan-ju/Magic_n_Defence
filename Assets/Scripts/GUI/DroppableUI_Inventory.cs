using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Inventory : DroppableUI
{
    public void OnPointerExit(PointerEventData eventData){
        Canvas canvas = image.GetComponentInParent<Canvas>();
        Color c = Color.white;
        c.a = 1.0f;
        image.color = c;
    }
}
