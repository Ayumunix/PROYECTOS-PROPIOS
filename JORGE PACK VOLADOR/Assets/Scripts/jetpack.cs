using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetpack : MonoBehaviour {

	public GameObject bullet;
	// Use this for initialization
	bool shooting = false;
	void Start () {
		StartCoroutine ("shootingProcess");
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKey (KeyCode.Space)) {
			Instantiate (bullet, transform.position, Quaternion.identity);
		}*/
		if (Input.GetKeyDown (KeyCode.Space)) {
			shooting = true;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			shooting = false;
		}
	}
	IEnumerator shootingProcess(){
		while (true) {
			if (shooting) {
				Instantiate (bullet, transform.position, Quaternion.identity);

			}
			yield return new WaitForSeconds (0.1f);
		}
	}
}
