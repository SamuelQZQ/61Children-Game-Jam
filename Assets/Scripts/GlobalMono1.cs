using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMono1 : MonoBehaviour {

    private GameObject UpCat;
    private GameObject DownCat;


	// Use this for initialization
	void Start () {
        UpCat = GameObject.FindGameObjectWithTag("WholeCat");
        DownCat = GameObject.FindGameObjectWithTag("Cat2");
	}
	
	// Update is called once per frame
	void Update () {
        Global.HungryDegree1 = UpCat.GetComponent<UpCat>().hungry;
        Global.HungryDegree2 = DownCat.GetComponent<DownCat>().hungry;
    }
}

public class Global
{
    public static bool isPoo = false;
    public static bool isPee = false;
    public static bool gameEnd = false;
    public static int HungryDegree1 = 100;
    public static int FoodCount1 = 0;
    public static int HungryDegree2 = 100;
    public static int FoodCount2 = 0;
}
