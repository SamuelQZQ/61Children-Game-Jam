using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitTipsControl : MonoBehaviour {

    UpCat cat;
    Animator anim;
	void Start () {
        cat = GameObject.FindGameObjectWithTag("WholeCat").GetComponent<UpCat>();
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        anim.SetBool("isReadyShit", cat.isReadyPoo);
	}
}
