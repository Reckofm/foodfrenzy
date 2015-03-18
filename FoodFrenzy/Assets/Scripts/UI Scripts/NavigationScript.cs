using UnityEngine;
using System.Collections;

public class NavigationScript : MonoBehaviour {
 
	public string buttonLabel;
	public string sceneName;
	
	private void OnGUI()
	{
		GUI.Box(new Rect(10,10,100,70), "Menu");

		Rect button = new Rect(20,40,80,20);
		if(GUI.Button(button, buttonLabel))
		{
			Application.LoadLevel(sceneName);
		}
	}
 
}
