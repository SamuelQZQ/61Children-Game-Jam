// this script should be attached to food1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour {

    public FoodType foodType;

    public int hungryVal, shitVal, weightVal;
    public bool isDrink;
    UpCat cat;


	
	void Awake () {
        cat = GameObject.FindGameObjectWithTag("Cat1").GetComponent<UpCat>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cat1")
        {
            cat.ChangeVal(hungryVal, shitVal, weightVal);

            if (isDrink) cat.SetPee();
                
            Destroy(this.gameObject);
        }
    }
}
