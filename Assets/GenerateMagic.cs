using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMagic : MonoBehaviour
{
    public GameObject magic;
    public GameObject magician;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1){
            GameObject new_magic = Instantiate(magic);// Instantiate(magic);
            // new_magic.transform.SetParent(magician.transform);
            // new_magic.transform.position = magician.transform.position + new Vector3(0.2f, 0.9f, 0);
            timer = 0;
        }
        
    }
}
