using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScript : MonoBehaviour {

    public Text timeText;
    public Text gameoverText;
    public static float timeLeft = 45f;

	// Use this for initialization
	void Start () {
        gameoverText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        timeLeft = timeLeft - Time.deltaTime;
        timeText.text = "Time Left: " + (int)(timeLeft);
		
        if (timeLeft < 0) {
            gameoverText.enabled = true;

        }


	}
}
