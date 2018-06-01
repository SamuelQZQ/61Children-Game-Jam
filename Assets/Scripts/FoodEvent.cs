// this script should be attached to food1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cat1")
        {
            Destroy(this.gameObject);
        }
    }
}
