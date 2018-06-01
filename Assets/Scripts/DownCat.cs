
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCat : MonoBehaviour {

    public int hungry, shit, weight;

    bool wantPee;
    float waitPeeTime;
    public float peeDelay;

    bool godMode;
    float godStartTime, godDelayTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeVal(int hungryVal, int shitVal, int weightVal)
    {
        weight += weightVal;
        hungry += hungryVal;
        shit += shitVal;
    }

    public void SetGod(float delayTime)
    {
        // TODO: start god
        godMode = true;
        godDelayTime = delayTime;
        godStartTime = Time.time;
    }
}
