using System.Collections;
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
        playerGameObject.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
    }

    public void GameOver()
    {
        isGameOver = true;
    }

}
