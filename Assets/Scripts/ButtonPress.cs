using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

    public Animator blockAnimator;

    private string buttonToPress = "space";
    private int timesToPress = 3;

    private int trackPresses = 0;

	void Update () {
        if (Input.GetKeyDown(buttonToPress))
        {
            trackPresses++;
            if (trackPresses >= timesToPress)
            {
                blockAnimator.SetTrigger("explode");
            }
        }
	}
}
