using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_bridge : MonoBehaviour
{
    public GameObject man;
    public GameObject book;
    public GameObject rock_road;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("book"))
        {
            rock_road.SetActive(true);
        }
    }
}
