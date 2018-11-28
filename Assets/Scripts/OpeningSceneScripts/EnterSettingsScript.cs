using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterSettingsScript : MonoBehaviour {

	public void enterSettings(){
		SceneManager.LoadScene ("SettingsScene");
	}
}
