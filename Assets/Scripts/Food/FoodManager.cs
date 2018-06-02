using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {


    public GameObject[] foodsCandidates;
    public Transform[] lootPoints;
    public float deltaFreshTime;

    private GameObject[] foods;
    private float[] lastFreshTime;
    private int numOfFoods;

	// Use this for initialization
	void Start () {
        numOfFoods = lootPoints.Length;
        foods = new GameObject[numOfFoods];
        lastFreshTime = new float[numOfFoods];
	}
	
	// Update is called once per frame
	void Update () {

        if(Global.gameStart) {
            for (int i = 0; i < numOfFoods; ++i)
            {
                if (foods[i] == null)
                {
                    if (lastFreshTime[i] < 0)
                    {
                        lastFreshTime[i] = Time.time;
                    }

                    if (Time.time - lastFreshTime[i] > deltaFreshTime)
                    {
                        CrateFood(i);
                    }

                }
            }
        }
	}

    private void CrateFood(int i)
    {
        lastFreshTime[i] = -1;
        foods[i] = Instantiate(foodsCandidates[(int)Random.Range(0, foodsCandidates.Length)],
                       lootPoints[i].position,
                       Quaternion.identity);
    }
}
