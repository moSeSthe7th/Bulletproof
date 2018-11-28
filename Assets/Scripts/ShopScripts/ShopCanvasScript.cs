using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopCanvasScript : MonoBehaviour {

	public BallObject[] balls;
	public int currentBall;
	private bool[] isBallOwnedBool;

	public Text goldCounterText;

	void Awake(){
		setGoldText ();
		isBallOwnedBool = PlayerPrefsX.GetBoolArray ("isBallOwnedArray", false, 14);
        balls[0].isOwned = true;
		for (int i = 1; i < balls.Length; i++) {
			balls [i].isOwned = isBallOwnedBool [i];
		}

	}

	public void setGoldText()
	{
		goldCounterText.text = PlayerPrefs.GetInt("Gold", 0).ToString();
	}

	/*public void changeBallTexture(){
		Debug.Log ("changeballtexturea girdi");
		DataScript.ballTexture = balls [currentBall].texture;
		DataScript.isBallTextureChanged = true;
	}*/

	public void startGame(){
		SceneManager.LoadScene ("SampleScene");
	}
}
