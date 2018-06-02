// this script should be attached to food1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour {

    public FoodType foodType;

    public int hungryVal, shitVal, weightVal;
    public bool isDrink, isPower;
    public float godTime;

    private bool isTouched = false;

    UpCat cat;
    DownCat cat2;
	
	void Awake () {
        cat = GameObject.FindGameObjectWithTag("WholeCat").GetComponent<UpCat>();
        cat2 = GameObject.FindGameObjectWithTag("Cat2").GetComponent<DownCat>();
    }

    // Use this for initialization
    void Start () {
        GameObject wholeCat = GameObject.FindGameObjectWithTag("WholeCat");
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), wholeCat.GetComponent<Collider2D>());
        this.GetComponent<Rigidbody2D>().Sleep();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cat1" && !isTouched)
        {
            Destroy(this.gameObject);
            Global.FoodCount1 ++ ;
            cat.ChangeVal(hungryVal, shitVal, weightVal);
            if (isDrink) cat.SetPee();
        }
        else if (collision.tag == "Cat1Stick")
        {
            Debug.Log("Wake Up!!");
            this.GetComponent<Rigidbody2D>().WakeUp();
            isTouched = true;
        }

    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cat2")
        {
            Destroy(this.gameObject);
            Global.FoodCount2 ++;
            cat2.ChangeVal(hungryVal, shitVal, weightVal);
            if (isPower) cat2.SetGod(godTime);
        }

    }
}
