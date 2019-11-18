using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressControl : MonoBehaviour
{
    public float newValue;
    //bool checkProgress = false;
    void Awake()
    {
        newValue = 0f;
    }

    // Use this for initialization
    void Start()
    {
        //CurrentValue = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Level1Completed()
    {
        newValue = 1.0f;
    }

    //public void CheckValue()
    //{
      //  float actualValue = currentValue;
    //}

}
