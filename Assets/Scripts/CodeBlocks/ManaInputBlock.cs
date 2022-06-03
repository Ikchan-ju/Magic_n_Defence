using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ManaInputBlock : NumBlock
{
    private float mana;
    public float manaChargingSpeed;
    public float manaChargingRegistance;
    // Start is called before the first frame update
    public override void Start()
    {
        mana = 0.0f;
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        if(transform.parent.name == "IfSlot_InputNum" || transform.parent.name == "IfSlot_ReferenceNum"){
            mana += manaChargingSpeed*Time.deltaTime/(1 + mana/manaChargingRegistance);
            number = mana;
            base.Update();
        }
    }
}

