using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSystem : MonoBehaviour
{
    public GameObject endgame;
    
    public void Start()
    {
        endgame.SetActive(false);
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene("game");
        Time.timeScale = 1;
    }

    public void quitgame()
    {
        Application.Quit();
    }

}
