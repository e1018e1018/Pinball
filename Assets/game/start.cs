using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour {
    public GameObject ball;
    public Text text;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            ball.SetActive(true);
            Destroy(text);
        }
	}
}
