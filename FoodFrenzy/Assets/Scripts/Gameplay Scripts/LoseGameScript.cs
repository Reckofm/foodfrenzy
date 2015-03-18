using UnityEngine;
using System.Collections;

public class LoseGameScript : MonoBehaviour 
{
	
	IEnumerator returnToTitle()
	{
		this.BeginFade(-1);
		yield return new WaitForSeconds(fadeSpeed);
		Application.LoadLevel("title_scene");
	}
	
	public void OnTriggerEnter2D(Collider2D other) 
	{
		this.returnToTitle();
		Application.LoadLevel("title_scene");
	}
    
}
