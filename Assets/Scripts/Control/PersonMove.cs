// this script should be attached to the palyer's role

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour {

    public float Scale = 50.0f;

    private GameObject Player;
    private bool dir = true;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("WholeCat");
    }

    // Update is called once per frame
    void Update () {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal"), 0) * Scale);
        if (Input.GetAxis("Horizontal") > 0 && dir == false)
        {
            Player.transform.Rotate(new Vector3(180, 0, 0));
            dir = true;
        }
        if (Input.GetAxis("Horizontal") < 0 && dir == true)
        {
            Player.transform.Rotate(new Vector3(180, 0, 0));
            dir = false;
        }
    }

}
