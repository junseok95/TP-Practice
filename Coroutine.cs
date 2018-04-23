using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour {

	[SerializeField]
	private int nFrames = 100;

	[SerializeField]
	private float slowDownScale = 0.03f;
	// Use this for initialization
	void Start () {
		
	}
	//코루틴
	IEnumerator slow(int n_frames)
	{
		Time.timeScale = slowDownScale;
		while (n_frames > 0)
		{
			n_frames--;
			yield return new WaitForEndOfFrame();
		}
		Time.timeScale = 1.0f;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("n"))
		{
			StartCoroutine(slow(30));
		}
	}
}
