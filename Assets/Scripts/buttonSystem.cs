using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSystem : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("game");
    }

    public void quitgame()
    {
        Application.Quit();
    }

}
