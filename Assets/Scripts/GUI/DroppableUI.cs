using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DroppableUI : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{
    private Image image;
    private RectTransform rect;

    private void Awake(){
        image = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData){
        Color y = Color.yellow;
        y.a = 0.6f;
        image.color = y;
    }

    public void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag != null){
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        Canvas canvas = image.GetComponentInParent<Canvas>();
        Color c = Color.white;
        if(canvas.name == "InventoryCanvas")
            c.a = 1.0f;
        else
            c.a = 0.0f;
        image.color = c;
    }
}
