using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    public GameObject Hungry1;
    public GameObject Hungry2;
    public GameObject FoodCount1;
    public GameObject FoodCount2;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Hungry1.GetComponent<Image>().fillAmount = (float)Global.HungryDegree1 / 100;
        FoodCount1.GetComponent<Image>().fillAmount = (float)Global.FoodCount1 / 50;
        Hungry2.GetComponent<Image>().fillAmount = (float)Global.HungryDegree2 / 100;
        FoodCount2.GetComponent<Image>().fillAmount = (float)Global.FoodCount2 / 50;
    }
}
