using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject endLevelPanel;




    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


public void GameOver()
    {
        Invoke("ShowOverPanel", 2.0f);
        Debug.Log("GamerOver");
    }

    public void ShowOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void EndLevel1()
    {
        Invoke("ShowCompletePanel", 2.0f);
        Debug.Log("LevelComplete");
    }



    public void ShowCompletePanel()
    {
        endLevelPanel.SetActive(true);
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }

    public void ExitToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}

