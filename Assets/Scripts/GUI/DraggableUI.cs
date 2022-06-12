using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform canvas;
    private Transform previousParent;
    private RectTransform rect;
    private CanvasGroup canvasGroup;
    private Vector3 goFront = new Vector3(0, 0, 100f);

    private void Awake(){
        if(transform?.GetComponentsInParent<Canvas>() != null && transform.GetComponentsInParent<Canvas>().Length != 0){
            Init();
        }
    }
    public void Init(){
        canvas = transform.GetComponentsInParent<Canvas>()[0].transform;
        rect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData){
        previousParent = transform.parent;

        transform.SetParent(canvas);
        transform.SetAsLastSibling();
        print(transform.GetSiblingIndex());
        // transform.SetAsFirstSibling();

        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData){
        rect.position = eventData.position;
        rect.position += goFront;
    }

    public void OnEndDrag(PointerEventData eventData){
        if(transform.parent == canvas){
            transform.SetParent(previousParent);
            rect.position = previousParent.GetComponent<RectTransform>().position + goFront;
        }

        canvasGroup.alpha = 1.0f;
        canvasGroup.blocksRaycasts = true;
    }
}
