using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . SceneManagement;
using UnityEngine.UI;

public class menucontroller : MonoBehaviour {
	Text scoree ;
	// Use this for initialization
	void Start () {
		scoree = GameObject.Find ("highscore").GetComponent<Text> ();

		scoree.text = "Highscore: " + PlayerPrefs.GetInt ("puntajepantalla");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void playClick(){
		SceneManager.LoadScene ("mero game");
	}
}
