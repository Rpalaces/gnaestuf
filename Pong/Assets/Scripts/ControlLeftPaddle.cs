using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLeftPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) && transform.position.y < 3f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 0.2f), 0.5f);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -3f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y - 0.2f), 0.5f);
        }
    }
}
