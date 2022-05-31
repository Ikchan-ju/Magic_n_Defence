using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI_Inventory : DroppableUI
{
    public override void OnPointerExit(PointerEventData eventData){
        print("child");
        SetTransparency(Color.white, 1.0f);
    }
}
