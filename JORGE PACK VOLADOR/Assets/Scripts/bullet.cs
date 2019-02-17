using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		float valX = Random.Range (-100, 100);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (valX, -500));
	}
	
	// Update is called once per frame
	void Update () {
		/*if (transform.position.y <= -3.5) {
			Destroy (gameObject);
		}*/

	}
	void OnTriggerEnter2D(Collider2D col ){
		
		if (col.tag == "Floor") {
			//Debug.Log ("EAAAAA");
			Destroy (gameObject);
		}
	}
}
