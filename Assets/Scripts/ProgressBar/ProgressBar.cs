using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    public GameObject Hungry1;
    public GameObject Hungry2;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Hungry1.GetComponent<Image>().fillAmount = (float)Global.HungryDegree1 / 10;
        Hungry2.GetComponent<Image>().fillAmount = (float)Global.HungryDegree2 / 10;
    }
}
