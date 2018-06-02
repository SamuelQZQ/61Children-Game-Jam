using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public GameObject UIBar;

    private GameObject Camera;
    private Animator animator;
    private GameObject cat2;
    private float gravity;

    private void Awake()
    {
        UIBar.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        cat2 = GameObject.FindGameObjectWithTag("WholeCat");
        animator = Camera.GetComponent<Animator>();
        gravity = cat2.GetComponent<Rigidbody2D>().gravityScale;
        cat2.GetComponent<Rigidbody2D>().gravityScale = 0;
        UIBar.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.normalizedTime >= 1.0f)
        {
            UIBar.SetActive(true);
            cat2.GetComponent<Rigidbody2D>().gravityScale = gravity;
            Global.gameStart = true;
        }
	}
}
