using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisInputTests : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        Debug.Log($"h axis: {Input.GetAxis("Horizontal")}");
    }
}
