using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume : MonoBehaviour {
    private AudioSource audioSource;
    public Slider Volume;
    public static float x;
    private float y;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = y;
    }
	
	// Update is called once per frame
	void Update () {
        x = Volume.value;
        audioSource.volume = x;
        y = x;
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
