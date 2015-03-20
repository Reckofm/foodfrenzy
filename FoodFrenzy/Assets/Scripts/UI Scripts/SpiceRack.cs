using UnityEngine;
using System.Collections;

public class SpiceRack : MonoBehaviour {

	public MenuInfo[] spices;

	public static MenuInfo cur;
	
	void OnGUI() 
	{
		// Begin Gui
		GUILayout.BeginArea(new Rect(Screen.width/2 - 150, Screen.height - 30, 300, 100));
		GUILayout.BeginHorizontal("box");
		
		// Draw each unuits BuildInfo
		foreach (MenuInfo bi in spices) 
		{
			if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
			{
				cur = bi;
			}
		}
		// End Gui
		
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
