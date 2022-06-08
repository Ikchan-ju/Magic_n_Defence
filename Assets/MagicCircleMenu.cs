using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircleMenu : MonoBehaviour
{
    public GameObject canvas;
    private bool isActive = false;
    public void ClickFunction(){
        print("Click");
        isActive = !isActive;
        canvas.SetActive(isActive);
    }
}
