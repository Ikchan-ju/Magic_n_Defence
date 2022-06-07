using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireBall : MonoBehaviour, IPointerClickHandler
{
    public float mana;
    public float manaChargingSpeed;
    public float angle=0;
    public float speed;
    public float radius;
    private float timer = 0;
    private bool bTrigger;
    private Vector3 centerPosition;
    // Start is called before the first frame update
    void Start()
    {
        // mana = 1f;
        timer = Random.Range(0, 5);
        centerPosition = transform.position;
        transform.position = centerPosition + new Vector3(-radius * Mathf.Cos(timer), radius * Mathf.Sin(timer), 0);
    }

    // Update is called once per frame
    void Update()
    {
        mana += manaChargingSpeed * Time.deltaTime;
        angle -= mana*Time.deltaTime*180;
        angle = angle%360;
        transform.Rotate(0, 0, -mana*Time.deltaTime*180);
        timer += Time.deltaTime;
        if(bTrigger){
            ShootMagic();
        }else{
            transform.position = centerPosition + new Vector3(-radius * Mathf.Cos(timer), radius * Mathf.Sin(timer), 0);
        }if(Input.GetKey(KeyCode.Z)){
            print("keydown");
            ShootMagic();
            Destroy(transform.gameObject, 7f);
        }

    }
    public void OnPointerClick(PointerEventData eventData){
        print("Event");
        ShootMagic();
    }

    void ShootMagic(){
        bTrigger = true;
        // print("Shooting Fire Ball");
        centerPosition += new Vector3(speed * Time.deltaTime, 0, 0); 
        transform.position = centerPosition + new Vector3(-radius * Mathf.Cos(timer), radius * Mathf.Sin(timer), 0);//+ new Vector3(speed * Time.deltaTime, 0, 0); 
    }
}
