using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	void OnMouseUpAsButton() {
		// Is there something to build?
		if (MenuBuild.cur != null) {
			// Build it
			Instantiate(MenuBuild.cur.gameObject, transform.position, Quaternion.identity);
			CoinCollect.score -= MenuBuild.cur.price;
			MenuBuild.cur = null;
		}
	}

}
