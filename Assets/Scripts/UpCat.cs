using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCat : MonoBehaviour {

    public int hungry, shit, weight;

    bool wantPee;
    float waitPeeTime;
    public float peeDelay;

    bool godMode;
    float godStartTime, godDelayTime;
    void Start () {
        wantPee = false;
        godMode = false;
	}
	
	void Update () {
        if(wantPee && Time.time - waitPeeTime > peeDelay) {
            wantPee = false;
            // TODO: start pee 
        }

        if(godMode && Time.time - godStartTime > godDelayTime) {
            godMode = false;
            // TODO: end god
        }
	}

    public void ChangeVal(int hungryVal, int shitVal, int weightVal) 
    {
        weight += weightVal;
        hungry += hungryVal;
        shit += shitVal;
    }

    public void SetPee()
    {
        wantPee = true;
        waitPeeTime = Time.time;
    }

}
