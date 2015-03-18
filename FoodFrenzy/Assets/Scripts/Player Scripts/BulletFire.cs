using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public GameObject bullet;
	
	public float shootingInterval = 0.5f;
	
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("Shoot", 0, shootingInterval);
	}
	
	void Shoot() 
	{
		if (this.enemyInFront()) 
		{
			Instantiate (bullet, transform.position, Quaternion.identity);
		}
	}
	
	bool enemyInFront() 
	{
		// Raycast from the right of the game to the plant
		Vector2 origin = new Vector2(9.5f, transform.position.y);
		RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);
		
		// Find out if any Zombie was hit
		foreach (RaycastHit2D hit in hits) 
		{
			if (hit.collider != null &&
			    hit.collider.gameObject.tag == "Enemy")
				return true;
		}
		return false;
	}

}
