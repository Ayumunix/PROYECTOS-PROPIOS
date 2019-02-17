using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject particle;

	Rigidbody2D rb;
	float rand;

	// Use this for initialization
	void Start () {

		rand = Random.Range(-3, 3);

		rb = GetComponent<Rigidbody2D>();
		//rb.AddForce(new Vector2(-400, 0)); 

	}

	// Update is called once per frame
	void Update () {

		//transform.Translate(new Vector3(-0.1f, 0, 0));


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
