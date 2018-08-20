using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GetComponent<AudioSource> ().Play ();
			GetComponent<Animation> ().Play ();

			RaycastHit hit;
			Physics.Raycast (
				this.transform.position,
				this.transform.TransformDirection (Vector3.forward),
				out hit);
			hit.transform.SendMessage ("MakeDamage");
		}
	}
}
