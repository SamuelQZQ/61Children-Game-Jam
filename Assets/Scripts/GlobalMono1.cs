using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMono1 : MonoBehaviour {

    public Text timeLeft;
    public Text foodCount;
    public GameObject Chief;
    public GameObject EndBG;
    public GameObject ReturnButton;
    public int BallonCount;
    public GameObject Ballon;

    private GameObject UpCat;
    private GameObject DownCat;

	// Use this for initialization
	void Start () {
        UpCat = GameObject.FindGameObjectWithTag("WholeCat");
        DownCat = GameObject.FindGameObjectWithTag("Cat2");
        Chief.SetActive(false);
        EndBG.SetActive(false);
        ReturnButton.SetActive(false);
        Ballon.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Global.gameStart)
        {
            Global.TimeLeft -= Time.deltaTime;
            if ((int)Global.TimeLeft == 0)
            {
                Global.gameEnd = true;
                Global.gameStart = false;
            }
            timeLeft.text = ((int)Global.TimeLeft).ToString();
            foodCount.text = ((int)(Global.FoodCount1 + Global.FoodCount2)).ToString();
            Global.HungryDegree1 = UpCat.GetComponent<UpCat>().hungry;
            Global.HungryDegree2 = DownCat.GetComponent<DownCat>().hungry;
        }
        if (Global.gameEnd)
        {
            Chief.SetActive(true);
            AnimatorStateInfo info = Chief.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
            if (info.normalizedTime >= 0.5f)
                EndBG.SetActive(true);
            if (info.normalizedTime >= 1.0f)
                ReturnButton.SetActive(true);

        }
        if ((Global.FoodCount1 + Global.FoodCount2) == BallonCount)
        { 
            Ballon.SetActive(true);
        }

    }
}

public class Global
{
    public static bool isPoo = false;
    public static bool isPee = false;
    public static bool isRightMove = false;
    public static bool gameStart = false;
    public static bool gameEnd = false;
    public static float TimeLeft = 10;
    public static int HungryDegree1 = 100;
    public static int FoodCount1 = 0;
    public static int HungryDegree2 = 100;
    public static int FoodCount2 = 0;
}
