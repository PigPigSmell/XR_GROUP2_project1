using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorTeleport : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void TestFunc()
    {
        
        player.transform.position = new Vector3(-42.63f, 0.32f, 26.86f);
        SceneManager.LoadScene(2);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "axe")
        {
            this.gameObject.GetComponent<AudioSource>().enabled = true;
            Destroy(other.gameObject);
            Invoke("TestFunc", 1f);
            
        }
    }
}
