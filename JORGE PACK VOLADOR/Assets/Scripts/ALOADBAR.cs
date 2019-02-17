using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALOADBAR : MonoBehaviour {

	Rigidbody2D rb;
	int numlaser = 100;
	public GameObject laser;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (0, 1000));
		SpawnSelector();
		Instantiate (laser,transform.position,Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {



		if (transform.position.y > 2.3) {
			Vector2 velocity= rb.velocity;
			velocity.y = -10;
			rb.velocity = velocity;
		}

		if (transform.position.y < -2.3) {
			Vector2 velocity= rb.velocity;
			velocity.y = 10;
			rb.velocity = velocity;
		}
	}
	IEnumerator SpawnLaser(){

		for (int i = 0; i < numlaser; i++) {
			yield return new WaitForSeconds (4f);
			Instantiate (laser,transform.position,Quaternion.identity);
			//Destroy (gameObject);
		}
	}
	void SpawnSelector(){
		StartCoroutine ("SpawnLaser");
	}
}
