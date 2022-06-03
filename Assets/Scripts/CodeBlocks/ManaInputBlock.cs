using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ManaInputBlock : NumBlock
{
    public float manaGenSpeed;
    // Start is called before the first frame update
    override void Start()
    {
        number = 0.0f;
        base.Start();
    }

    // Update is called once per frame
    override void Update()
    {
        number += manaGenSpeed/Time.deltaTime;
        base.Update();
    }
}

