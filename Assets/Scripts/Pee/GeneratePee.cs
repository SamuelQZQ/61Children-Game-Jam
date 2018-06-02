// the script should be attached to PooPoint 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePee : MonoBehaviour {

    public GameObject Pee;
    public float Scale = 1.0f;
    public GameObject Anchor;
    public GameObject Midpoint;

    private Vector3 dir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() { 
        if (Global.isPee)
        {
            dir = Midpoint.transform.position - Anchor.transform.position;
            dir = Vector3.Cross(dir, new Vector3(0, 0, 1));
            GameObject pee = Instantiate(Pee);
            pee.transform.position = this.transform.position;
            pee.GetComponent<Rigidbody2D>().AddForce( dir * Scale );
            StartCoroutine(TimeDelay(3));
        }
	}

    IEnumerator TimeDelay(float time)
    {
        yield return new WaitForSeconds(time);
        Global.isPee = false;
    }
}
