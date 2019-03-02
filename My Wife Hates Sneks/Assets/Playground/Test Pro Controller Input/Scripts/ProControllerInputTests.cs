using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProControllerInputTests : MonoBehaviour {
    private string[] _joystickNames;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(_joystickNames == null || _joystickNames.Length < 1) {
            _joystickNames = Input.GetJoystickNames();
            Debug.Log("joystick names are: ");
            foreach(string joystickName in _joystickNames) {
                Debug.Log(joystickName);
            }
        }
	}
}
