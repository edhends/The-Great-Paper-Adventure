using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
		// Ship speed
		public Vector2 speed = new Vector2(15,15);

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

		// Shooting
		bool shoot = Input.GetButtonDown ("Fire1");
		shoot |= Input.GetButtonDown ("Fire2");

		if (shoot) 
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				weapon.Attack (false);
			}
		}
	}

	void FixedUpdate()
	{
		// Moves the player
		rigidbody2D.velocity = movement;
	}
}
