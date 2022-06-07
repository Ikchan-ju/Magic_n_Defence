using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float mana;
    public float manaChargingSpeed;
    public float angle=0;
    public float speed;
    public float trigger;
    public int loopCount;
    private int count = 0;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        // mana = 1f;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        mana += manaChargingSpeed * Time.deltaTime;
        angle -= mana*Time.deltaTime*180;
        angle = angle%360;
        transform.Rotate(0, 0, -mana*Time.deltaTime*180);
        if(count < loopCount){
            if(mana >= trigger){
                print("Add Fire Ball");
                mana = 0;
                count++;
                AddMagic();
            }
            return;
        }
        if(mana >= trigger){
            print("Shooting Fire Ball");
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    void AddMagic(){

    }
}
