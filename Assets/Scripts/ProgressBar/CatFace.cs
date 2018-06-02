using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatFace : MonoBehaviour {

    public Sprite hungry100;
    public Sprite hungry70;
    public Sprite hungry30;
    public int CatType;

    private float hungry;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CatType == 1)
            hungry = Global.HungryDegree1;
        else if (CatType == 2)
            hungry = Global.HungryDegree2;

        if (hungry > 70)
            this.GetComponent<Image>().sprite = hungry100;
        else if (hungry <= 70 && hungry > 30)
            this.GetComponent<Image>().sprite = hungry70;
        else
            this.GetComponent<Image>().sprite = hungry30;
    }
}
