using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveWithMouse : MonoBehaviour {

    float max = 7f, min = -6.4f;
    float rmax = 1.1f, rmin = -1.1f;
    Transform trans;
    Transform cat2;

    private void Start()
    {
        trans = GetComponent<Transform>();
        cat2 = GameObject.FindGameObjectWithTag("Cat2").GetComponent<Transform>();
    }

    void Update () {
        float posX = cat2.position.x;
        float x = (posX - min) / (max - min) * (rmax - rmin) + rmin;
        trans.position = new Vector3( x , 0.25f, -20f) ;
    }
}
