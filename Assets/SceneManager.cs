using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public bool isInstant;

    private void Awake()
    {
        if (isInstant)
        {
           SceneManager.LoadScene("GameScene");
        }
    }

    public void LoadInstant()
    {
        SceneManager.LoadScene("InstanceScene");
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}