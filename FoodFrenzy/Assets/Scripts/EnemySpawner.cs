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
	}
	
	void Spawn() 
	{
		Instantiate(enemy,
				transform.position,
				Quaternion.identity);
		this.numberOfEnemies--;
	}
}
