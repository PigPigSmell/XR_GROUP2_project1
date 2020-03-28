using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFreeAnim : MonoBehaviour {

    public GameObject player;
    public GameObject rock_road;
    public AudioSource audio;

	Vector3 rot = Vector3.zero;
	float rotSpeed = 40f;
	float start = 0, end = 0;
	Animator anim;
    bool audioPlay = false;

	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
        anim.enabled = false;
	}
    

    // Update is called once per frame
    void Update()
	{
        if (Input.GetKeyDown("b"))
        {
            audio.Play();
        }
		CheckKey();
		//gameObject.transform.eulerAngles = rot;
        if(Vector3.Distance(player.transform.position, this.transform.position) < 10){
            anim.enabled = true;
            start = Time.time;
        }
        if (audioPlay && !audio.isPlaying)
        {
            this.gameObject.SetActive(false);
        }
        if(start - end > 8)
        {
            GameObject.Find("Google1").GetComponent<AudioSource>().enabled = true;
            Invoke("audiotest", 6f);
        }
	}

    void audiotest()
    {
         GameObject.Find("Google3").GetComponent<AudioSource>().enabled = true;
    }
	void CheckKey()
	{
        /*
		// Walk
		if (Input.GetKey(KeyCode.W))
		{
			anim.SetBool("Walk_Anim", true);
		}
		else if (Input.GetKeyUp(KeyCode.W))
		{
			anim.SetBool("Walk_Anim", false);
		}

		// Rotate Left
		if (Input.GetKey(KeyCode.A))
		{
			rot[1] -= rotSpeed * Time.fixedDeltaTime;
		}

		// Rotate Right
		if (Input.GetKey(KeyCode.D))
		{
			rot[1] += rotSpeed * Time.fixedDeltaTime;
		}
        */

		// Roll
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (anim.GetBool("Roll_Anim"))
			{
				anim.SetBool("Roll_Anim", false);
			}
			else
			{
				anim.SetBool("Roll_Anim", true);
			}
		}

		// Close
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			if (!anim.GetBool("Open_Anim"))
			{
				anim.SetBool("Open_Anim", true);
			}
			else
			{
				anim.SetBool("Open_Anim", false);
			}
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("memory"))
        {
            rock_road.SetActive(true);
            other.gameObject.SetActive(false);
            audioPlay = true;
            GameObject.Find("Google2").GetComponent<AudioSource>().enabled = true;
        }
    }

}
