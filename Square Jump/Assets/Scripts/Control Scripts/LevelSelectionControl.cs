﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionControl : MonoBehaviour
{
    public GameObject levelSelection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
       // DisableCanvas();

    }

    public void Level1Button()
    {
        Application.LoadLevel("SampleScene");
        //DisableCanvas();

    }

    /*void DisableCanvas()
    {
        levelSelection.SetActive(false);
    }

    public void EnableCanvas()
    {
        levelSelection.SetActive(true);
    }*/
}
