using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour 
	{

	AudioSource ball;
	public AudioClip bounce;

	// Use this for initialization
	void Start () {
		ball = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Floor") {
			Debug.Log("Bounce");
			ball.clip = bounce;
			ball.Play();
		}
	}
}
