using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public Button button;
    public AudioMixer masterMixer;
    private OptionsMenu optionsMenu = new OptionsMenu();

    public void Start()
    {
		masterMixer.SetFloat("BGM", optionsMenu.LinearToDecibel(PlayerPrefs.GetFloat("musicSlider", 1f)));
	}

    public void LevelSelect(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene(2);
                break;
            case 2:
                SceneManager.LoadScene(3);
                break;
            case 3:
                SceneManager.LoadScene(4);
                break;
        }
    }

    public void Options()
    {
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);

        if (button.name == "OptionsButton")
            SceneManager.LoadScene("Scenes/Options");

        if (button.name == "ExitButton")
            Debug.Log("Exited");
            Application.Quit();
    }
}
