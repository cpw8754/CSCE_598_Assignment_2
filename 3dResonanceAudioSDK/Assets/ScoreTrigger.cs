using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour 
{
	Vector3 initialVelocity;
	Vector3 exitVelocity;

	Score_Board script;
	// Use this for initialization
	void Start () {
		script = GameObject.FindGameObjectWithTag("ScoreBoard").GetComponent<Score_Board>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter (Collider other) 
	{
		initialVelocity = other.transform.position; //.gameObject.GetComponent<Rigidbody>().velocity;
	}

	private void OnTriggerExit (Collider other) {
		exitVelocity = other.transform.position; //gameObject.GetComponent<Rigidbody>().velocity;
		Vector3 result = initialVelocity - exitVelocity;
		result = initialVelocity - exitVelocity;
		// if the Y coordinate evaluates to negative, the ball went through the hoop, else it bounced out

		//Debug.Log("Exit:" + exitVelocity + " - " + "Initial: " + initialVelocity + " = " + result);

		if (result.y > 0) 
		{
			script.UpdateTexts(true, true);
		}
		else
		{
			script.UpdateTexts(false, true);
		}
	}

}
