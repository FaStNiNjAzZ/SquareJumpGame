﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    LevelSelectionControl levelManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void LevelSelection()
    {
        Application.LoadLevel("LevelManager");
        //levelManager.EnableCanvas();
    }
}
