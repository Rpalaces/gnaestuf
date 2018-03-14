using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject ball;
    public GameObject start;

	// Use this for initialization
	void Start ()
    {
        ball.SetActive(false);
        start.SetActive(true);
	}

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            ball.SetActive(true);
            start.SetActive(false);
        }
	}
}
