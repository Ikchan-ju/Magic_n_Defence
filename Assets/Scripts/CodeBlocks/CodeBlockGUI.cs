using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlockGUI : MonoBehaviour
{
    // This Class is a parent class of every code parts
    // i.e. if, num, elemental, loop, class, ...
    // Start is called before the first frame update
    public float multiple = 1;
    public float source;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int damage = (int) (source * multiple);
    }

    int Action()
    {
        return (int) multiple;
    }
}
