using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	float last = 0;
	
	void OnCollisionStay2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Unit") 
		{
			if (Time.time - last >= 1)
			{
				coll.gameObject.GetComponent<Health>().doDamage(1);
				last = Time.time;
			}
		}
	}

}
