using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {

    public GameObject ball;
    public GameObject leftWall;
    public GameObject rightWall;
    public Text leftScore;
    public Text rightScore;
    public static int lScore, rScore;

    void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        lScore = 0;
        rScore = 0;
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left Wall")
        {
            lScore++;
        }
        if (collision.gameObject.name == "Right Wall")
        {
            rScore++;
        }
    }
}
