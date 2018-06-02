using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeeEvent : MonoBehaviour {

    private GameObject Cat;

	// Use this for initialization
	void Start () {
        Cat = GameObject.FindGameObjectWithTag("WholeCat");
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), Cat.GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
            Destroy(this.gameObject);
    }
}
