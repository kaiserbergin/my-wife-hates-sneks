using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInputTests : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Joystick1Button0)) {
            Debug.Log("KeyCode.Joystick1Button0");
        }
        if (Input.GetKey("joystick button 0")) {
            Debug.Log("joystick button 0");
        }
    }
}
