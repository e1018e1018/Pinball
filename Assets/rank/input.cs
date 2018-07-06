using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class input : MonoBehaviour {
    public static string name;
    public Text score;
    public InputField testInput;
    // Use this for initialization
    void Start () {
        score.text = game.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        name = testInput.text;
        PlayerPrefs.SetString("Name", name);
        PlayerPrefs.SetInt("Name", game.score);
        print(PlayerPrefs.GetString("Name"));
    }

    public void Save()
    {



        SceneManager.LoadScene(0);
    }
}
