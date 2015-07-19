using UnityEngine;
using System.Collections;

public class SpiceRack : MonoBehaviour {

	public MenuInfo[] spices;

	public static MenuInfo cur;
	
	void OnGUI() 
	{
		// Begin Gui
		GUILayout.BeginArea(new Rect(Screen.width/2 - 100, Screen.height - 50, 200, 50));
		GUILayout.BeginHorizontal("box");
		
		// Draw each unuits BuildInfo
		foreach (MenuInfo bi in spices) 
		{
			if (GUILayout.Button(new GUIContent(bi.previewImage)))
			{
				cur = bi;
			}
		}
		// End Gui
		
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
