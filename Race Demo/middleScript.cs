using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScript : MonoBehaviour {

    public static bool passMiddle = false;

    void OnTriggerEnter() {
        passMiddle = true;

    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
