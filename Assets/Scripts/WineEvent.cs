﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineEvent : MonoBehaviour {

    public int timeLast = 3;
    public float maxforce;
    public float scale;

    private GameObject Upcat;
    private float oldMaxForce;
    private float oldScale;

	// Use this for initialization
	void Start () {
        Upcat = GameObject.FindGameObjectWithTag("WholeCat");
        oldMaxForce = Upcat.GetComponent<CatDragStick>().maxForce;
        oldScale = Upcat.GetComponent<CatDragStick>().scale;
	}
	
	// Update is called once per frame
	void Update () {
        if (Global.isWine)
        {
            StartCoroutine(TimeDelay(timeLast));
            Upcat.GetComponent<CatDragStick>().maxForce = maxforce;
            Upcat.GetComponent<CatDragStick>().scale = scale;
        }
	}

    IEnumerator TimeDelay(int delay)
    {
        yield return new WaitForSeconds(delay);
        Global.isWine = false;
        Upcat.GetComponent<CatDragStick>().maxForce = oldMaxForce;
        Upcat.GetComponent<CatDragStick>().scale = oldScale;
    }
}
