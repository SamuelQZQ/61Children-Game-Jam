using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMono1 : MonoBehaviour {

    private GameObject UpCat;


	// Use this for initialization
	void Start () {
        UpCat = GameObject.FindGameObjectWithTag("WholeCat");
	}
	
	// Update is called once per frame
	void Update () {
        Global.HungryDegree1 = UpCat.GetComponent<UpCat>().hungry;

    }
}

public class Global
{
    public static bool isPoo = false;
    public static bool gameEnd = false;
    public static int HungryDegree1 = 100;
    public static int FoodCount1 = 0;
    public static int HungryDegree2 = 100;
    public static int FoodCount2 = 0;
}
