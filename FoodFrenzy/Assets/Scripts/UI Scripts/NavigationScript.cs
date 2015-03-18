using UnityEngine;
using System.Collections;

public class NavigationScript : MonoBehaviour {
 
	public Rect button = new Rect(100,100,100,100);
	public string buttonLabel;
	public string sceneName;
	
	private void OnGUI()
	{
		if(GUI.Button(button, buttonLabel))
		{
			Application.LoadLevel(sceneName);
		}
	}
 
}
