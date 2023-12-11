using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool pause=false;
    //public GameObject GameOverMenu;

    public void startButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void resumeButton()
    {
        //pauseMenu.SetActive(false);
        //pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }


    public void pauseButton()
    {
        //pauseMenu.SetActive(true);
        pause = true;
        Time.timeScale = 0f;
    }

    public void quitButton()
    {
        Application.Quit();
        Debug.Log("cýktý");
    }

    public void exitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GameOverExit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void GameOver()
    {
        //GameOverMenu.SetActive(true);
    }
    public void CizgiRomanButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !pause )
        {
            
            Debug.Log("donacak");
            //pauseMenu.SetActive(true);
            pauseButton();
        }
        if (Input.GetKeyDown(KeyCode.P) && pause)
        {
            pause = false;
            //pauseMenu.SetActive(false);

            //Time.timeScale = 1f;
            resumeButton();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitButton();
        }

    }


}
