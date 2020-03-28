using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            int idx = (SceneManager.GetActiveScene().buildIndex + 1) % 4;
            SceneManager.LoadScene(idx);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
