using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDragStick : MonoBehaviour {

    public float maxForce, scale;
    public Transform dragTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            
			Vector3 mousePositionOnScreen = Input.mousePosition;  
			Vector3  mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);  
            mousePositionInWorld.z = transform.position.z;

            Vector3 dragForce = dragTransform.position - mousePositionInWorld;
            dragForce = dragForce.normalized * (Global.HungryDegree2);
            dragForce *= -scale;
			if(dragForce.magnitude > maxForce) {
				dragForce =  dragForce.normalized * maxForce;
			}
            GetComponent<Rigidbody2D>().AddForceAtPosition(dragForce, dragTransform.position);
		}		
	}
	
	
}
