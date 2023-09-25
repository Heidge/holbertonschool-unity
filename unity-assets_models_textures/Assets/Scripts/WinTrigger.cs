using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text Timer_Text;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Timer_Text.fontSize = 60;
            Timer_Text.color = Color.green;
            Player.GetComponent<Timer>().enabled = false;
        }
    }
}
