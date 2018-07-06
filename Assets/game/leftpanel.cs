using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftpanel : MonoBehaviour {
    public GameObject lf;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        leftstick.check = true;
    }
    private void OnMouseUp()
    {
        leftstick.check = false;        
    }
}
