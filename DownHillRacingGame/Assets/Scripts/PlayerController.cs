using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	// public data

	public float speed;
	public AudioClip startBeep;
//	public GUIText playerTime;
//	public GUIText finishingTime;
//	public GUIText startCountDown;

	// private data

	// Keeps track of how many gates player has
	// gone through.
//	private float countDown;
//	private float timeStart;
//	private int gatesClearedCount;
//	private GUIText gateText;
//	private bool gameWon;


	// private methods
	private void Start()
	{
		// Start the countDown audio when game starts

		audio.PlayOneShot(startBeep);

		// Set gatesClearedCount to 0 at
		// the beginning of every game session.
//		gatesClearedCount = 0;

		// Set here in case it is not set in the unity editor
		speed = 500.0f; 

		// Set finish to false
//		gameWon = false;
//
//		// Counter that controls starting countdown
//		countDown = 3.0f;
//
//		timeStart = 0.0f;


	} // end private method Start

	// Update is called once per frame
//	private void Update()
//	{
//		if(countDown > 0)
//		{
//			startCountDown.text = "" + (int)countDown;
//			countDown -= Time.deltaTime;
//		}
//		else
//		{
//			startCountDown.text = "";
//		}
//
//		// Keep updating playerTime until they go through
//		// all the gates and they hit the bottom wall.
//		if(!gameWon && countDown < 0)
//		{
//			setCountText();
//		}
////		setCountText();
//
//	} // end private method Update


	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);
	} // end private method FixedUpdate


	// Method for detecting collisions with the gate entrances
//	void OnTriggerEnter(Collider other)
//	{
//		// When player collides with gameObject with
//		// the tag "Gate" will then deativate the particles
//		// and add one to cubeCount.
//		if (other.gameObject.tag == "Gate")
//		{
//			SetGateColorText();
//			other.gameObject.SetActive(false);
//			gatesClearedCount = gatesClearedCount + 1;
//		}
//
//		if(other.gameObject.tag == "FinishLine" && gatesClearedCount == 4)
//		{
//			gameWon = true;
//			finishingTime.text = "Finishing " + playerTime.text;
//		}
//
//	}

	// Change a gate label's color if a player
	// has passed through its corresponding gate.
//	void SetGateColorText()
//	{
//		GameObject gateText;
//
//		gateText = GameObject.FindWithTag("GateText");
//
//		gateText.guiText.color = Color.green;
//	}

//
//	private void setCountText()
//	{
//		timeStart += Time.deltaTime;
//		playerTime.text = "Time:  " + timeStart;
//	} // end private method setCountText
	// end private methods
} // end public class PlayerController
