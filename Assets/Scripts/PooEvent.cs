// this script should be attached to Poo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooEvent : MonoBehaviour {

    public bool End = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cat2")
        {
            Global.gameEnd = true;
            Debug.Log(" the game is end!!");
        }
    }
}
