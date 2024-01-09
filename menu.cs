using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Lvl 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MAIN MENU");
    }

}
