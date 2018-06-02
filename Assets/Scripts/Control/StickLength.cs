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
    private Vector3 AnchorPos;

	// Use this for initialization
	void Start () {
        AnchorPos = new Vector2(Person.transform.position.x, Person.transform.position.y) + Person.GetComponent<HingeJoint2D>().anchor;
        oldDis = (this.transform.position - AnchorPos).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
        AnchorPos = new Vector2(Person.transform.position.x, Person.transform.position.y) + Person.GetComponent<HingeJoint2D>().anchor;
        Dis = (this.transform.position - AnchorPos).magnitude;
        dir = this.transform.position - AnchorPos;
        Debug.DrawLine(this.transform.position, AnchorPos, Color.green);
        if (Input.GetAxis("Vertical") > 0 && (Dis - oldDis <= MaxOffset))   // if the up button was pressed
        {
            this.transform.position += dir * Scale;
        }
        if (Input.GetAxis("Vertical") < 0 && (Dis - oldDis >= -MaxOffset)) // if the down button was pressed 
        {
            this.transform.position += (-1 * dir * Scale);
        }
        }

    }
