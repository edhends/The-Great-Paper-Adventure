using UnityEngine;
using System.Collections;

/// <summary>
/// Player controller and behavior
/// </summary>

public class PlayerScript : MonoBehaviour 
	{
		// Ship speed
		public Vector2 speed = new Vector2(50,50);

		// Movement is stored
		private Vector2 movement;


	void Update () 
	{
	 	// Retrieves axis info
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		// Movement per direction
		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY);
	}

	void FixedUpdate()
	{
		// Moves the player
		rigidbody2D.velocity = movement;
	}
}
