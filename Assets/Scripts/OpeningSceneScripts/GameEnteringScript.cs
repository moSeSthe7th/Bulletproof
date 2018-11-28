using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnteringScript : MonoBehaviour {

	void Start () {
		int voiceInt = PlayerPrefs.GetInt("voiceToggler");
        Time.timeScale = 2f;

		if (voiceInt == 0)
		{
			AudioListener.pause = false;
		}
		else
		{
			AudioListener.pause = true;
			Debug.Log ("off");
		}
	}
	

}
