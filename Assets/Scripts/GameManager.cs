using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject GameOverMenu;
    
    public void startButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void resumeButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }


    public void pauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void quitButton()
    {
        Application.Quit();
        Debug.Log("cýktý");
    }

    public void exitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
    }
    public void GameOver()
    {
        GameOverMenu.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu.SetActive(true);
            pauseButton();
        }
    }


}
