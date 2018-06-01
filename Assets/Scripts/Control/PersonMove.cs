// this script should be attached to the palyer's role

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour {

    public float Scale = 50.0f;

    private GameObject Player;
    private Vector2 lastFrame;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player/Stick");
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal"), 0) * Scale);
        Vector2 velocity;
        velocity = this.GetComponent<Rigidbody2D>().velocity.normalized;
        if (velocity.x * lastFrame.x < 0)
            Player.transform.Rotate( new Vector3(180, 0, 0));

    }
    private void LateUpdate()
    {
        lastFrame = this.GetComponent<Rigidbody2D>().velocity.normalized;
    }
}
