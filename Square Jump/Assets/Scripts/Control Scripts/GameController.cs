using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject endLevelPanel;
    public Slider LevelProgressBar;
    float LevelProgress1;



    // Start is called before the first frame update
    void Start()
    {
        LevelProgress1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LevelProgressBar.value = Level1Progress();
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
        LevelProgress1 = 1.0f;

    }

    public void Level1Progress()
    {
        float progressBar = LevelProgress1;
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

