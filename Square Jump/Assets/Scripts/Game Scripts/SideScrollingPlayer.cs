﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollingPlayer : MonoBehaviour
{
    public float scrollSpeed = 5.0f;
    bool isGameOver = false;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        GameObject currentChild;
        for (int i = 0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            playerScroll(currentChild);
        }
    }

    void playerScroll(GameObject playerGameObject)
    {
        playerGameObject.transform.position -= Vector3.left * (scrollSpeed * Time.deltaTime);
    }

    public void GameOver()
    {
        isGameOver = true;
        transform.GetComponent<GameController>().GameOver();
    }

    public void EndLevel1()
    {
        isGameOver = true;
        transform.GetComponent<GameController>().EndLevel1();
    }

    public void HalfXSpeed()
    {
        scrollSpeed = 2.5f;
    }

    public void OneXSpeed()
    {
        scrollSpeed = 5.0f;
    }

    public void TwoXSpeed()
    {
        scrollSpeed = 10.0f;
    }

    public void ThreeXSpeed()
    {
        scrollSpeed = 15.0f;
    }

}
