using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRightPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 0.2f), 0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y - 0.2f), 0.5f);
        }
    }
}
