using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishScript : MonoBehaviour {

    public UnityEngine.UI.Text lapText;
    int lapCounter = 0;

	void OnTriggerEnter()
	{
        if (middleScript.passMiddle) {
            
            middleScript.passMiddle = false;
            lapCounter++;
            lapText.text = "Lap: " + lapCounter;
            gameScript.timeLeft += 45;

        }

	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
