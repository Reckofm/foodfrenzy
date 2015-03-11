using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) 
	{
		if (co.tag == "enemy") 
		{
			// Deal Damage, destroy Bullet
			co.GetComponent<Health>().doDamage(1);
			Destroy(gameObject);
		}
	}

}
