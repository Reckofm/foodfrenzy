using UnityEngine;
using System.Collections;

public class LoseGameScript : MonoBehaviour 
{
	
	public void OnTriggerEnter2D(Collider2D other) 
	{
		AutoFade.LoadLevel("title_scene" ,3,1,Color.black);
	}
    
}
