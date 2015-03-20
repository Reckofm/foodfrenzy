﻿using UnityEngine;
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
		if (this.numberOfEnemies > 0) 
		{
			Instantiate (enemy,
					transform.position,
					Quaternion.identity);
						this.numberOfEnemies--;
		} 
		else 
		{
			this.gameObject.tag = "Untagged";
		}
	}
}
