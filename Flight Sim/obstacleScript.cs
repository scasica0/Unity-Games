using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour {

	int pos = 0;
	bool reverse = false;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (pos > 100){
			reverse = true;
		}
		else if (pos < -100){
			reverse = false;
		}
		if (reverse) {
			pos -= 1;
		} 
		else {
			pos += 1;
		}

		this.transform.Translate (new Vector3 (pos, 0,0 ) * Time.deltaTime * speed);
	}
}
