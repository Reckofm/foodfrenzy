using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour {

	public GameObject prefab;

	void Start() 
	{
		InvokeRepeating("Spawn", 5, 7);
	}
	
	void Spawn() 
	{
		Instantiate(prefab,
		            transform.position,
		            Quaternion.identity);
	}
}
