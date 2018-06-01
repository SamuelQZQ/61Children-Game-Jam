﻿// this script should be attached to food1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour {

    public FoodType foodType;

    public int hungryVal, shitVal, weightVal;
    public bool isDrink, isPower;
    public float godTime;

    UpCat cat;
    DownCat cat2;
	
	void Awake () {
        cat = GameObject.FindGameObjectWithTag("WholeCat").GetComponent<UpCat>();
	}

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody2D>().Sleep();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cat1")
        {
            Destroy(this.gameObject);
            cat.ChangeVal(hungryVal, shitVal, weightVal);
            if (isDrink) cat.SetPee();
        }
        else if (collision.tag == "Cat1Stick")
            this.GetComponent<Rigidbody2D>().WakeUp();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cat2")
        {
            Destroy(this.gameObject);            
            cat2.ChangeVal(hungryVal, shitVal, weightVal);
            if (isPower) cat2.SetGod(godTime);
        }

    }
}