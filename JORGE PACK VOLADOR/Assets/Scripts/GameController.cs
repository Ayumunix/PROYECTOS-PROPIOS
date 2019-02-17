using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
	int NUMTROMPETA =100;
	public GameObject KFC;
	bool loseS;
	Text lacagaste;
	public int enteropuntaje;

	// Use this for initialization
	void Start () {
		Debug.Log("gamecontroller");
		 StartCoroutine("pollo");
		loseS = false;
		lacagaste = GameObject.Find ("score").GetComponent<Text>();
		StartCoroutine ("puntajellevas");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Player == null && loseS == false) {
			StartCoroutine ("loseprocess");
			loseS = true;
		}*/
		lacagaste.text = "PUNTAJE DE PRO - "+enteropuntaje;
		if(PlayerPrefs.GetInt("puntajepantalla")<enteropuntaje){
			PlayerPrefs.SetInt ("puntajepantalla", enteropuntaje);
		}
	}



	IEnumerator pollo() {
		for(int i=0;i<NUMTROMPETA;i++)
		{
			Instantiate(KFC);
			yield return new WaitForSeconds(4.0f);

		}


	}
	public void perdiste(){
		StartCoroutine ("loseprocess");
	}

	IEnumerator loseprocess(){
		

		//StopCoroutine ("meterup");
		GameObject.Find ("gameover").GetComponent<Text> ().enabled = true;
		StopCoroutine ("puntajellevas");
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene ("menu");

	}
	IEnumerator puntajellevas(){
		yield return new WaitForSeconds (1f);
		enteropuntaje++;
		StartCoroutine ("puntajellevas");
	}
}
