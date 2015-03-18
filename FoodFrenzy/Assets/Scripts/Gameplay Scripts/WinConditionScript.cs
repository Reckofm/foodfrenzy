using UnityEngine;
using System.Collections;

public class WinConditionScript : MonoBehaviour {

	public string sceneName;

	// Update is called once per frame
	void Update () {
		if(GameObject.FindWithTag("Respawn") == null && GameObject.FindWithTag("Enemy") == null)
		{
			Application.LoadLevel(sceneName);
		}
	}
}
