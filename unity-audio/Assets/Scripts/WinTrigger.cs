using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class WinTrigger : MonoBehaviour
{
    public Text Timer_Text;
    public GameObject WinCanvas;
    public GameObject TimerCanvas;
    public AudioSource BackgroundMusic;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            TimerCanvas.SetActive(false);
            WinCanvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            BackgroundMusic.enabled = false;
        }
    }
}
