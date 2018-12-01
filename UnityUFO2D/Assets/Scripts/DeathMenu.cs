using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public static bool GameHasEnded = false;
    public GameObject deathMenuUI;

    void Update()
    {
       
    }
    public void Dead()
    {
        if(GameHasEnded == false)
        {
            deathMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameHasEnded = true;
        }
    }
    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        GameHasEnded = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameHasEnded = false;
    }
}
