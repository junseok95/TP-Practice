using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
			rb.AddForce(Vector3.forward * 10);
		if (Input.GetKey("s"))
			rb.AddForce(Vector3.back * 10);
		if (Input.GetKey("d"))
			rb.AddForce(Vector3.right * 10);
		if (Input.GetKey("a"))
			rb.AddForce(Vector3.left * 10);
		if (Input.GetKeyDown("space"))
			rb.AddForce(Vector3.up * 500);
	}
}
