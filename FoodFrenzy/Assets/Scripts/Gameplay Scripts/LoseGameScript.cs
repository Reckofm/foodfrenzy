using UnityEngine;
using System.Collections;

public class LoseGameScript : MonoBehaviour 
{
	
	public void OnTriggerEnter2D(Collider2D other) 
	{
		Application.LoadLevel("title_scene");
	}
    
}
