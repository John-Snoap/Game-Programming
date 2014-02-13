using UnityEngine;
using System.Collections;

public class ClearGate : MonoBehaviour
{
	// public data
	public GUIText gateNumber;

	//private GameObject
	private int gatesClearedCount;
	

	// Use this for initialization
	void Start()
	{
		gatesClearedCount = 0;
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	// Method for detecting collisions with the gate entrances
	void OnTriggerEnter(Collider other)
	{
		// When player collides with gameObject with
		// the tag "Gate" will then deativate the particles
		// and add one to cubeCount.
		if (other.gameObject.tag == "Player")
		{
			SetGateColorText();
			this.gameObject.SetActive(false);
			gatesClearedCount = gatesClearedCount + 1;
		}
		
//		if(other.gameObject.tag == "FinishLine" && gatesClearedCount == 4)
//		{
//			finish = true;
//			finishingTime.text = "Finishing " + playerTime.text;
//		}
	} // end private method OnTriggerEnter
	
	// Change a gate label's color if a player
	// has passed through its corresponding gate.
	void SetGateColorText()
	{
		//GameObject gateText;

		gateNumber.color = Color.green;
		//gateText = GameObject.FindWithTag("GateText");
		
		//gateText.guiText.color = Color.green;
	}
}
