using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour 
{
	
	public static int score = 100;
	
	void OnMouseDown() 
	{
		score += 25;

		Destroy(gameObject);
	}

}
