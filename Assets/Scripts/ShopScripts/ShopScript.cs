using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour {

	//private UIScript uIScript;
	private ShopCanvasScript shopCanvasScript;

	// Use this for initialization
	void Start () {
		//uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
		shopCanvasScript = FindObjectOfType (typeof(ShopCanvasScript)) as ShopCanvasScript;
	}

	public void increaseGoldBy(int goldAmount){
		int gold = PlayerPrefs.GetInt ("Gold", 0);
		gold += goldAmount;
		PlayerPrefs.SetInt ("Gold", gold);
		Debug.Log ("Gold increased by: " + goldAmount.ToString ());
		shopCanvasScript.setGoldText ();
	}

	public void decreaseGoldBy(int goldAmount){
		int gold = PlayerPrefs.GetInt ("Gold", 0);
		gold -= goldAmount;
		PlayerPrefs.SetInt ("Gold", gold);
		Debug.Log ("Gold increased by: " + goldAmount.ToString ());
		shopCanvasScript.setGoldText ();
	}

	public void removeAds(){
		DataScript.isAdsPurchased = true;
	}
}
