using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{
    public Button button;

    public void Options()
    {
        if (button.name == "OptionsButton")
                SceneManager.LoadScene("Scenes/Options");
        if (button.name == "ExitButton")
            Debug.Log("Exited");
            Application.Quit();
    }
}
