using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public GameObject Player;
    private bool pauseActived = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseActived)
            {
                Pause();
            }
            else
            {
                Resume();
            } 
        }
    }
    public void Pause()
    {
        Player.GetComponent<Timer>().enabled = false;
        pauseActived = true;
        pauseCanvas.SetActive(true);
    }

    public void Resume()
    {
        Player.GetComponent<Timer>().enabled = true;
        pauseActived = false;
        pauseCanvas.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        pauseCanvas.SetActive(false);
        Player.GetComponent<Timer>().enabled = false;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
