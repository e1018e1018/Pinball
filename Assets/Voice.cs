using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour {
    private AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        volume.x=audioSource.volume;
    }
	
	// Update is called once per frame
	void Update () {
        audioSource.volume = volume.x;
    }
}
