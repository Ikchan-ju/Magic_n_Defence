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
                return;
            }
            DroppableUI_Code.BackupElement();
            print("1");
            DroppableUI_Code.DeactivateElement();
            print("2");
            DroppableUI_Code.SetClassBlock(classBlock);
            
            print("Set");
            // DroppableUI_Code.classBlock = classBlock;
            // print("3");
            // DroppableUI_Code.manaInputBlock = classBlock.manaInputObject;
            // print("4");
            // DroppableUI_Code.logicalOperatorBlock = classBlock.logicalOperatorObject;
            // print("5");
            // DroppableUI_Code.referenceNumBlock = classBlock.referenceNumObject;
            // print("6");
            // DroppableUI_Code.actionBlock = classBlock.actionObject;
            // print("7");
            DroppableUI_Code.ActivateElement();
            print("Print");
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
