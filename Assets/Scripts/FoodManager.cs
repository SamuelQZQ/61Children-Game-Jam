using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour {


    public GameObject[] foodsCandidates;
    public Transform[] lootPoints;

    private GameObject[] foods;
    //private float[] 
    private int numOfFoods;

	// Use this for initialization
	void Start () {
        numOfFoods = lootPoints.Length;
        foods = new GameObject[numOfFoods];
        for (int i = 0; i < numOfFoods; ++i) {
            foods[i] = Instantiate(foodsCandidates[(int)Random.Range(0, foodsCandidates.Length)],
                                   lootPoints[i].position, 
                                   Quaternion.identity); 
        }
	}
	
	// Update is called once per frame
	void Update () {
        
        for (int i = 0; i < numOfFoods; ++i)
        {
            if(foods[i] == null) {
                foods[i] = Instantiate(foodsCandidates[(int)Random.Range(0, foodsCandidates.Length)],
                                   lootPoints[i].position,
                                   Quaternion.identity);    
            }
        }
	}
}
