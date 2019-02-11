using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Board : MonoBehaviour 
{
	public Text[] Scores;
	public Text[] BallsRemainingTexts;

	// Use this for initialization
	void Start () 
	{
		//Find the number of balls in play before throwing
		GameObject[] balls = GameObject.FindGameObjectsWithTag("Basketball");

		foreach (Text s in Scores) 
		{
			int score;
			//int.TryParse(s.text, out score);
			score = 0;
			s.text = score.ToString();
		}

		foreach (Text b in BallsRemainingTexts) 
		{
			int ballCount;
			//int.TryParse(b.text, out balls);
			//balls--;
			ballCount = balls.Length;
			b.text = ballCount.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void UpdateTexts(bool Sank, bool Thrown) 
	{
		if (Sank)
		{
			foreach (Text s  in Scores) 
			{
				int score;
				int.TryParse(s.text, out score);
				score++;
				s.text = score.ToString();
			}
		}

		foreach (Text b in BallsRemainingTexts) 
		{
			int balls;
			int.TryParse(b.text, out balls);
			balls--;
			b.text = balls.ToString();
		}
	}
}
