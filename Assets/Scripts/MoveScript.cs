using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour 
{

	// Speed
	public Vector2 speed = new Vector2(5,5);

	// Direction
	public Vector2 direction = new Vector2(-1,0);

	private Vector2 movement;


	void Update () 
	{
		// Movement
		movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
