using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	//타임스케일
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("n"))
			Time.timeScale = 0.03f;
		else if (Input.GetKeyUp("n"))
			Time.timeScale = 1.0f;
	}
}
