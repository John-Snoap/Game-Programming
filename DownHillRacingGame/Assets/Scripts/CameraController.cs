using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	// public data
	public GameObject player;
	// end public data

	// private data
	private Vector3 offset;
	// end private data

	// private methods
	private void Start() // Use this for initialization
	{
		offset = transform.position - player.transform.position;
	} // end private method Start

	private void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	} // end private method LateUpdate
	// end private methods
} // end public class CameraController
