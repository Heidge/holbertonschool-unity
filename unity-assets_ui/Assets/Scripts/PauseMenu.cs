using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public GameObject Player;
    public Text Timer_Text;
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
}
