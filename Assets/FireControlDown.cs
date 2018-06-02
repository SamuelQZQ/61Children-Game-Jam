using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControlDown : MonoBehaviour
{


    DownCat cat;
    Animator anim;
    void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Cat2").GetComponent<DownCat>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (cat.isFire)
        {
            cat.isFire = false;
            anim.SetTrigger("Fire");
        }

    }
}

