﻿using UnityEngine;
using System.Collections;

public class MenuBuild : MonoBehaviour {
	
	public MenuInfo[] units;
	
	public static MenuInfo cur;
	
	void OnGUI() 
	{
		// Begin Gui
		GUILayout.BeginArea(new Rect(Screen.width/2 - 100, -7, 200, 100));
		GUILayout.BeginHorizontal("box");
		
		// Draw each unuits BuildInfo
		foreach (MenuInfo bi in units) 
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