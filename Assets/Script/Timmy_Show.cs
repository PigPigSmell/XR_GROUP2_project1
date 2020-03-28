using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timmy_Show : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject leftHand;
    public GameObject Timmy;

    // Start is called before the first frame update
    void Start()
    {
        Timmy.SetActive(false);
        Timmy.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame

    

    void Update()
    {
        if(Mathf.Abs(leftHand.transform.position.y - rightHand.transform.position.y) < 0.1f && Vector3.Distance(leftHand.transform.position, rightHand.transform.position) < 0.2f)
        {
            
            Timmy.transform.position = (leftHand.transform.position + rightHand.transform.position) / 2;
            Timmy.SetActive(true);
        }
        else
        {
            Timmy.SetActive(false);
        }
    }

    
}
