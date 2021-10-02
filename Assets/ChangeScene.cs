using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    public void LoadNextSceneProvider()
    {
        gameManager.LoadNextLevel();
    }
}
