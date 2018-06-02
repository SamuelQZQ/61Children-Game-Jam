using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCatMiao : MonoBehaviour {

    AudioSource audioSource;
	
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
        	
	}

    public void PlayAudio(AudioClip clip) {
        audioSource.PlayOneShot(clip);
    }
}
