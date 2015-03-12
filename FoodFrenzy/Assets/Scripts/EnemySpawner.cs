using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	
	public int numberOfEnemies;
	public int firstSpawn;
	public int interval;

	void Start() 
	{
			InvokeRepeating("Spawn", this.firstSpawn, this.interval);
			numberOfEnemies--;
	}
	
	void Spawn() 
	{
		while(this.numberOfEnemies > 0)
		{
			Instantiate(enemy,
		            transform.position,
		            Quaternion.identity);
		}
	}
}
