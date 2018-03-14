using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private BallScript bs;

    public int totalScores, rs, ls;

    void Awake()
    {
        bs = GetComponent<BallScript>();
    }

    // Update is called once per frame
    void Update () {

	}
}
