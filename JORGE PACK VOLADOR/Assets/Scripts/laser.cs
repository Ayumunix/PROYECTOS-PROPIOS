using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {
	float rand;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x -= 0.1f;
		pos.y =  Mathf.Cos (pos.x) + rand; 
		transform.position = pos;

		if (transform.position.x <= -15) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag.Equals ("Player")) {
			Destroy (col.gameObject);
			Destroy (gameObject);
			GameObject obj = GameObject.FindGameObjectWithTag ("GameController");
			GameController perdedor = obj.GetComponent < GameController > ();
			perdedor.perdiste ();
		}
	}
}
