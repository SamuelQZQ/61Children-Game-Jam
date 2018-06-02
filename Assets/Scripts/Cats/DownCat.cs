
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCat : MonoBehaviour {

    public int hungry = 100;
    float hungryTimeTick;
    public float hungryDeTime = 1;

    bool godMode;
    float godStartTime, godDelayTime;

    CatDragStick catDragStick;

    [HideInInspector]public bool isFire;

	// Use this for initialization
	void Start () {
        catDragStick = GameObject.FindGameObjectWithTag("WholeCat").GetComponent<CatDragStick>();
        isFire = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (godMode && Time.time - godStartTime > godDelayTime)
        {
            godMode = false;
            // TODO: end god
        }

        hungryTimeTick += Time.deltaTime;
        if (hungryTimeTick >= hungryDeTime)
        {
            hungry -= 1;
            hungryTimeTick -= hungryDeTime;
        }

        if (hungry <= 0)
        {
            // TODO: game over
        }

        //catDragStick.maxForce = ;
	}

    public void ChangeVal(int hungryVal, int shitVal, int weightVal)
    {
        hungry -= hungryVal;
    }

    public void SetGod(float delayTime)
    {
        // TODO: start god
        godMode = true;
        godDelayTime = delayTime;
        godStartTime = Time.time;
    }
}
