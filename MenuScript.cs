using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 100;
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GarageScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
