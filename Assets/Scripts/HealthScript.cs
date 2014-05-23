using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	// Enemy hp
	public int hp = 1;

	public bool isEnemy = true;

	// Inflicts damage, destroys enemy if dead
	public void Damage(int damageCount)
	{
		hp -= damageCount;
		if (hp <= 0) 
		{
			Destroy(gameObject);
		}
	}

	// Runs actions when hit, destroys shot
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) 
		{
			if (shot.isEnemyShot != isEnemy)
			{
				Damage (shot.damage);
				Destroy (shot.gameObject);
			}
		}
	}
	
}
