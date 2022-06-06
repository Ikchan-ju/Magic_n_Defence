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
        if(mana >= trigger){
            print("Shooting Fire Ball");
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        // else
        {
            angle -= mana*Time.deltaTime*180;
            angle = angle%360;
            transform.Rotate(0, 0, -mana*Time.deltaTime*180);
        }
    }
}
