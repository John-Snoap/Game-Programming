using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinishLine : MonoBehaviour
{
	// public data
	public GUIText playerTime;
	public GUIText finishingTime;
	public GUIText startCountDown;
	// end public data

	// private data
	private bool gameWon;
	private GameObject[] gates;
	private float countDown;
	private float timeStart;
	//private bool gameWon;
	// end private data

	// Use this for initialization
	void Start ()
	{
		gameWon = false;
		gates =  GameObject.FindGameObjectsWithTag("GateText");
		
		// Counter that controls starting countdown
		countDown = 3.0f;
		
		timeStart = 0.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(countDown > 0)
		{
			startCountDown.text = "" + (int)countDown;
			countDown -= Time.deltaTime;
		}
		else
		{
			startCountDown.text = "";
		}

		// Keep updating playerTime until they go through
		// all the gates and they hit the bottom wall.
		if(!gameWon && countDown < 0)
		{
			setCountText();
		}
	}

	// Method for detecting collisions with the gate entrances
	void OnTriggerEnter(Collider other)
	{
		// When player collides with gameObject with
		// the tag "Gate" will then deativate the particles
		// and add one to cubeCount.
//		if (other.gameObject.tag == "Player")
//		{
//			SetGateColorText();
//			this.gameObject.SetActive(false);
//			gatesClearedCount = gatesClearedCount + 1;
//		}


		if(other.gameObject.tag == "Player")
		{
			foreach(GameObject gate in gates)
			{
				if(gate.guiText.color.Equals(Color.green))
				{
					gameWon = true;
				} // end if
				else
				{
					gameWon = false;
					break; // this gets us out of the foreach loop
				} // end else
			} // end foreach loop

			if(gameWon)
			{
				finishingTime.text = "Finishing " + playerTime.text;
			} // end if
		} // end if
	} // end private method OnTriggerEnter

	private void setCountText()
	{
		timeStart += Time.deltaTime;
		playerTime.text = "Time:  " + timeStart;
	} // end private method setCountText
}
