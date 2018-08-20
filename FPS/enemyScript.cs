using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

	bool isShot = false;

	public void MakeDamage(){
		if (!isShot) {
			GetComponent<Animation> ().Play ("back_fall");
			isShot = true;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isShot) {
			GetComponent<Animation> ().Play ("walk");
			this.transform.Translate (new Vector3 (0, 0, 1) * Time.deltaTime);
			this.transform.Rotate (new Vector3 (0, Random.Range (-90, 90), 0) * Time.deltaTime);
		}
	}
}
