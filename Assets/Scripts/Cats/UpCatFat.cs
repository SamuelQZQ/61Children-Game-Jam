using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCatFat : MonoBehaviour {

    public UpCat upCat;
    Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
	}
	
	void Update () {
        animator.SetInteger("Weight", upCat.weight);
	}
}
