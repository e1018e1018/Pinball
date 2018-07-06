using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {
    public GameObject start, setting, rank;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void Game()
    {
        if (gameObject.tag == "start")
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Setting()
    {
        if (gameObject.tag == "setting")
        {
            SceneManager.LoadScene(1);
        }
    }
    public void Rank()
    {
        if (gameObject.tag == "rank")
        {
            SceneManager.LoadScene(8);
        }
    }
    public void _Main()
    {
        if (gameObject.tag == "main")
        {
            SceneManager.LoadScene(0);
        }
    }
}
