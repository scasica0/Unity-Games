using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeScript : MonoBehaviour {

	public float speed = 30.0f;
	public GameObject explosionEffect;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * speed;

		transform.Rotate(Input.GetAxis("Vertical"),0.0f,Input.GetAxis("Horizontal"));

	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("crashing")) {
			explosionEffect.SetActive (true);
			player.SetActive (false);
			speed = 0.0f;
		}
	}

}
