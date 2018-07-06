using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class good : MonoBehaviour
{
    public GameObject Text;
    float TranslateSpeed = 0.5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text.transform.Translate(Vector3.up * TranslateSpeed);
        if (Input.GetMouseButton(0))
        {
            TranslateSpeed = 2f;
        }
        else
        {
            TranslateSpeed = 0.5f;
        }
        if (Text.transform.position.y > 650)
        {
            SceneManager.LoadScene(7);
        }
    }
}
