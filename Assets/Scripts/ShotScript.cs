using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour 
{
	// Set damage
	public int damage = 1;

	public bool isEnemyShot = false;


	void Start () 
	{
		Destroy (gameObject, 20);
	}
}
