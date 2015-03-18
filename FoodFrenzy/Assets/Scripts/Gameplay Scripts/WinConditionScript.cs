using UnityEngine;
using System.Collections;

public class WinConditionScript : MonoBehaviour {

	public string sceneName;

	// Update is called once per frame
	void Update () 
	{
		if(GameObject.FindWithTag("Respawn") == null && GameObject.FindWithTag("Enemy") == null)
		{
			this.ChangeLevel();
			Application.LoadLevel(sceneName);
		}
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find ("GameController").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel(sceneName);
	}
}