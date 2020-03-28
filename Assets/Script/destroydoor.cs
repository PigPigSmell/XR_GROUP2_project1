using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroydoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        print("collision");
        if(other.gameObject.tag == "door")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            print("doordes");
        }
    }
}
