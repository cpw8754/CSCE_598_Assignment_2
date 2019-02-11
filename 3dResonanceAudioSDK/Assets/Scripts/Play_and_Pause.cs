using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_and_Pause : MonoBehaviour 
{
	public AudioSource guitar;

	// Use this for initialization
	void Start () 
	{
		if (guitar.isPlaying) 
		{
			Debug.Log("Gerudo Valley Theme!");
		}
		else 
		{
			guitar.Play();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp(KeyCode.P) && guitar.isPlaying) 
		{
			guitar.Pause();
			Debug.Log("Pausing Music!");
		} 
		else if (Input.GetKeyUp(KeyCode.P) && !guitar.isPlaying)
		{
			//guitar.Play();
			guitar.UnPause();
			Debug.Log("Resuming Music!");
		}
		
	}
}
