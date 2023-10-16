using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text Timer_Text;
    public GameObject Player;
    public GameObject WinCanvas;
    public GameObject TimerCanvas;
    public TextMeshProUGUI FinalTime;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<Timer>().enabled = false;
            TimerCanvas.SetActive(false);
            WinCanvas.SetActive(true);
            FinalTime.text = Timer_Text.text;
        }
    }
}
