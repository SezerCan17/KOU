using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject resumeButton;
    public bool pause = false;
    //public GameObject GameOverMenu;
    public void Start()
    {
        pause = false;
    }
    public void startButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void resumeButton_()
    {
        //pauseMenu.SetActive(false);
        //pauseMenu.SetActive(false);
        //resumeButton.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }


    public void pauseButton()
    {
        //pauseMenu.SetActive(true);
        //resumeButton.SetActive(true);
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
    public void WinMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }
    public void WinMenu_Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(pause==false)
            {
                pause = true;
                pauseButton();
            }
            else if(pause==true) 
            {
                pause = false;
                resumeButton_();
            }

            Debug.Log("donacak");
            //pauseMenu.SetActive(true);
            
        }
        /*if (Input.GetKeyDown(KeyCode.O) && pause == true)
        {
            pause = false;
            //pauseMenu.SetActive(false);

            //Time.timeScale = 1f;
            
        }*/
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitButton();
        }

    }
}



