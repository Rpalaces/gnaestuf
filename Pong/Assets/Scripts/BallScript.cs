using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Vector2 position;

    // Use this for initialization
    void Start () {
        position = new Vector2(Random.Range(-100, 100), Random.Range(-201, 100));
        this.GetComponent<Rigidbody>().AddForce(position);
    }
}
    