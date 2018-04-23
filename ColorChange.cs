using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

	private MeshRenderer mr;
	// Use this for initialization
	void Start()
	{
		mr = GetComponent<MeshRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown("r"))
		mr.material.color = Color.red;
	}
}
