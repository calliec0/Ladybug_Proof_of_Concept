using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void LoadOptions()
    {
        Debug.Log("Go to Options");
    }

    public void LoadMenu()
    {
        Debug.Log("Go to the main Menu");
        Time.timeScale = 1;
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit the game entirely");
        Application.Quit();
    }
}
