using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoo : MonoBehaviour {

    public GameObject Poo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Global.isPoo)
        {
            Debug.Log("POO!!!");
            GameObject poo = Instantiate(Poo);
            poo.transform.position = this.transform.position;
            Global.isPoo = false;
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
    }
}
