// this script should be attached to stick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickLength : MonoBehaviour {

    public float MaxOffset = 1.0f;
    public float Scale = 0.1f;
    public GameObject Person;

    private float Dis;
    private float oldDis;
    private Vector3 dir;

	// Use this for initialization
	void Start () {
        oldDis = (this.transform.position - Person.transform.position).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
        Dis = (this.transform.position - Person.transform.position).magnitude;
        dir = this.transform.position - Person.transform.position;
        if (Input.GetAxis("Vertical") > 0 && (Dis - oldDis <= MaxOffset ))   // if the up button was pressed
            this.transform.position += dir * Scale;
        if (Input.GetAxis("Vertical") < 0 && (Dis - oldDis >= -MaxOffset)) // if the down button was pressed 
            this.transform.position += (-1 * dir * Scale);
        }

}
