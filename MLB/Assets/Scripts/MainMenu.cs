using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{

    public void MainPlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void MainQuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
