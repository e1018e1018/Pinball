using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game : MonoBehaviour {
    public Text score_text;
    public static int score;
	// Use this for initialization
	void Start () {
        score = 0;
        score_text.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        score_text.text=score.ToString();
        if (gameObject.transform.position.y < 160)
        {
            if (score <= 1000)
            {
                SceneManager.LoadScene(4);
            }
            if (score > 1000 && score <= 2500)
            {
                SceneManager.LoadScene(5);
            }
            if (score > 2500)
            {
                SceneManager.LoadScene(6);
            }
        }
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left Flipper" || collision.gameObject.name == "Right Flipper") 
        {
            score += 20;
        }
        if (collision.gameObject.name == "Block")
        {
            score += 10;
        }
        if (collision.gameObject.name == "RED")
        {
            score += 100;
        }
    }

}
