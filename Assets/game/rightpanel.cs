using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightpanel : MonoBehaviour
{
    public GameObject rf;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        rightstick.check = true;
    }
    private void OnMouseUp()
    {
        rightstick.check = false;
    }
}
