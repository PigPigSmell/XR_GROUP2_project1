using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timmymagic : MonoBehaviour
{
    public bool timmyget = false;
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
        GameObject.Find("Player").GetComponent<Timmy_Show>().enabled = true;
        timmyget = true;
    }
}
