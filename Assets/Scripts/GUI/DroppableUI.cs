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
        SetTransparency(Color.yellow, 0.6f);
    }
    public void SetTransparency(Color color, float transparency){
        color.a = transparency;
        image.color = color;
    }

    public virtual void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag != null){
            PutOn(eventData);
        }
    }

    public void PutOn(PointerEventData eventData){
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
    }

    public virtual void OnPointerExit(PointerEventData eventData){
        SetTransparency(Color.white, 0.0f);
    }
}
