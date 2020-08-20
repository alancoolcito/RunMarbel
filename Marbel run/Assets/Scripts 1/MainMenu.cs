using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool paused = false;

    public void PlaGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuiGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void PauseGame()
    {
        if (paused == false)
        {
            Time.timeScale = 0;
            paused = true;
        }
        else
        {
            Time.timeScale = 1;
            paused = !paused;
        }
    }
}
