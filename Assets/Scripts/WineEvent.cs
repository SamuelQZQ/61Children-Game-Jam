using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineEvent : MonoBehaviour {

    public int timeLast = 3;
    public float maxforce;
    public float scale;

    private GameObject Upcat;
    private AudioSource BGM;
    private float oldMaxForce;
    private float oldScale;

    public SpriteRenderer head1, head2;

	// Use this for initialization
	void Start () {
        Upcat = GameObject.FindGameObjectWithTag("WholeCat");
        BGM = GameObject.Find("GameManager").GetComponent<AudioSource>();
        oldMaxForce = Upcat.GetComponent<CatDragStick>().maxForce;
        oldScale = Upcat.GetComponent<CatDragStick>().scale;
	}
	
	// Update is called once per frame
	void Update () {
        if (Global.isWine)
        {
            StartCoroutine(TimeDelay(timeLast));
            BGM.Stop();
            Upcat.GetComponent<CatDragStick>().maxForce = maxforce;
            Upcat.GetComponent<CatDragStick>().scale = scale;
            head2.color = head1.color = new Color(1, 0.5f , 0.5f, 1);
        }
	}

    IEnumerator TimeDelay(int delay)
    {
        yield return new WaitForSeconds(delay);
        Global.isWine = false;
        BGM.Play();
        Upcat.GetComponent<CatDragStick>().maxForce = oldMaxForce;
        Upcat.GetComponent<CatDragStick>().scale = oldScale;
        head2.color = head1.color = Color.white;
    }
}
