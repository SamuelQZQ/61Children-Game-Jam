// this script should be attached to the palyer's role

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour {

    public float Scale = 50.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal"), 0) * Scale);
    }
}
