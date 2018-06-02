using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControlUp : MonoBehaviour {


    UpCat cat;
    Animator anim;
    void Start()
    {
        cat = GameObject.FindGameObjectWithTag("WholeCat").GetComponent<UpCat>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(cat.isFire) {
            cat.isFire = false;
            anim.SetTrigger("Fire");
        }

    }
}
