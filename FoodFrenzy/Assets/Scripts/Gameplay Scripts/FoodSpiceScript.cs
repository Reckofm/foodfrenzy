using UnityEngine;
using System.Collections;

public class FoodSpiceScript : MonoBehaviour {

	void OnMouseUpAsButton() {
		if (MenuBuild.cur != null) {
			// Build it
			if(CoinCollect.score >= MenuBuild.cur.price)
			{
				Instantiate(MenuBuild.cur.gameObject, transform.position, Quaternion.identity);
				CoinCollect.score -= MenuBuild.cur.price;
				MenuBuild.cur = null;
			}
		}
	}

}
