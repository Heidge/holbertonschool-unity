using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public GameObject Player;
    private bool pauseActived = false;
    public AudioMixerSnapshot paused;
	public AudioMixerSnapshot unpaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
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
		paused.TransitionTo(0.000001f);
		Time.timeScale = 0f;
		pauseActived = true;
        pauseCanvas.SetActive(true);
    }

    public void Resume()
    {
		unpaused.TransitionTo(0.000001f);
		Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
		pauseActived = false;
        pauseCanvas.SetActive(false);
    }

    public void Restart()
    {
		unpaused.TransitionTo(0.000001f);
		Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        pauseCanvas.SetActive(false);
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
