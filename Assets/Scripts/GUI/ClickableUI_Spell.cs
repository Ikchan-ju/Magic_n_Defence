using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableUI_Spell : MonoBehaviour, IPointerClickHandler
{
    public GameObject code;
    private RectTransform rect;
    private float left = -15f;
    private float right = -15f;
    private float top = -15f;
    private float bottom = -15f;

    private void Awake(){
        rect = GetComponent<RectTransform>();
    }
    public void OnPointerClick(PointerEventData eventData){
        print("click event. clickCount : " + eventData.clickCount + ", clickTime : " + eventData.clickTime);
        if(eventData.clickCount  == 1){
            print("Click");
            ClassBlock classBlock = GetComponentInChildren<ClassBlock>();
            if(classBlock == null){
                print("Null");
                GameObject new_code = Instantiate(code);
                PutOn(new_code);
                classBlock = GetComponentInChildren<ClassBlock>();
                if(DroppableUI_Code.classBlock == null)
                    DroppableUI_Code.SetClassBlock(classBlock);
            }
            DroppableUI_Code.BackupElement();
            DroppableUI_Code.DeactivateElement();
            DroppableUI_Code.SetClassBlock(classBlock);
            DroppableUI_Code.ActivateElement();
        }else if(eventData.clickCount  == 2){
            print("Double Click");
        }
    }

    public void PutOn(GameObject gameObject){
        gameObject.transform.SetParent(transform);
        RectTransform rectTransform = gameObject.transform.GetComponent<RectTransform>();
        rectTransform.SetLeft(left);
        rectTransform.SetRight(right);
        rectTransform.SetTop(top);
        rectTransform.SetBottom(bottom);
        rectTransform.position = rect.position;
        gameObject.GetComponent<DraggableUI>().Init();
    }
}
