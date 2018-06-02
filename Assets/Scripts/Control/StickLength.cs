// this script should be attached to stick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickLength : MonoBehaviour {

    public float MaxOffset = 1.0f;
    public float Scale = 1.0f;
    public GameObject Anchor;
    public GameObject MidPoint;

    private float Dis;
    private float oldDis;
    private float oldZ;
    private Vector3 dir;

	// Use this for initialization
	void Start () {
        oldDis = (MidPoint.transform.position - Anchor.transform.position).magnitude;
        oldZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        Dis = (MidPoint.transform.position - Anchor.transform.position).magnitude;
        dir = ( MidPoint.transform.position - Anchor.transform.position).normalized;
        dir.z = 0;
        Debug.DrawLine(MidPoint.transform.position, Anchor.transform.position, Color.green);

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
