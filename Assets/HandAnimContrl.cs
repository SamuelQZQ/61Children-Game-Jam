using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimContrl : MonoBehaviour {

    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetInteger("hungry", Global.HungryDegree2);
	}
}
