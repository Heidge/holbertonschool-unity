using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Timer_Text;
    private float tempsActuel = 0f;
    private bool gamePaused = false;

    // Update is called once per frame
    void Update()
    {
            tempsActuel += Time.deltaTime;
            Timer_Text.text = FormatTemps(tempsActuel);  
    }

    string FormatTemps(float temps)
    {
        int minutes = Mathf.FloorToInt(temps / 60);
        int secondes = Mathf.FloorToInt(temps % 60);
        float centisecondes = (temps * 100) % 100;

        return string.Format("{0:00}:{1:00}:{2:00}", minutes, secondes, centisecondes);
    }
}
