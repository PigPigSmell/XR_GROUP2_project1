using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class playVideo : MonoBehaviour
{
    public GameObject canvas;
    public GameObject video;
    public VideoPlayer beginVideo;

    private float start = 0, end = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (video.activeSelf)
        {
            end = Time.time;
            if(end - start > 58)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void pressTrigger()
    {
        canvas.SetActive(false);
        video.SetActive(true);
        start = Time.time;
    }
}
