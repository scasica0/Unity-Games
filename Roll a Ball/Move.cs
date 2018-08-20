using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	public float speed; 
	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "Score: " + score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveH, 0.0f, moveV);

		GetComponent<Rigidbody> ().AddForce (movement * speed);


	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			score++;
			scoreText.text = "Score: " + score.ToString ();
		}
		if (score >= 8)
			scoreText.text = "YOU WIN!";
	}
}
