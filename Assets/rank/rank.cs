using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class rank : MonoBehaviour {
    public Text one, two, three;
    public Text first, second, third;
    string new_name;
	// Use this for initialization
	void Start () {
        new_name = input.name;
        one.text = PlayerPrefs.GetString("Name1");
        two.text = PlayerPrefs.GetString("Name2");
        three.text = PlayerPrefs.GetString("Name3");
        first.text = PlayerPrefs.GetInt("Name1").ToString();
        second.text = PlayerPrefs.GetInt("Name2").ToString();
        third.text = PlayerPrefs.GetInt("Name3").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Name") > PlayerPrefs.GetInt("Name1"))
        {
            PlayerPrefs.SetString("Name1",new_name);
            PlayerPrefs.SetInt("Name1", game.score);
        }
        else if(PlayerPrefs.GetInt("Name") > PlayerPrefs.GetInt("Name2") && PlayerPrefs.GetInt("Name") < PlayerPrefs.GetInt("Name1"))
        {
            PlayerPrefs.SetString("Name2", new_name);
            PlayerPrefs.SetInt("Name2", game.score);
        }
        else if(PlayerPrefs.GetInt("Name") > PlayerPrefs.GetInt("Name3") && PlayerPrefs.GetInt("Name") < PlayerPrefs.GetInt("Name1") && PlayerPrefs.GetInt("Name") < PlayerPrefs.GetInt("Name2"))
        {
            PlayerPrefs.SetString("Name3", new_name);
            PlayerPrefs.SetInt("Name3", game.score);
        }
	}
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
