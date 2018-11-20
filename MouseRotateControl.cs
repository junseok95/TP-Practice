using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotateControl : MonoBehaviour {

    Rotate rot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        print("1");
        if(rot == null)
        {
            rot = gameObject.AddComponent<Rotate>();
        }
        else
        {
            Destroy(rot);
            rot = null;
        }
    }
}
