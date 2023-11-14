using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle InvertY;
    public AudioMixer masterMixer;
    public Slider sfxSlider;
    public Slider musicSlider;

    public void Start()
    {
        if (PlayerPrefs.GetInt("isInverted") == 1)
            InvertY.isOn = true;
        else
            InvertY.isOn = false;
    }
    public void Back()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));
    }

    public void Apply()
    {
        if (InvertY.isOn)
            PlayerPrefs.SetInt("isInverted", 1);
        else
            PlayerPrefs.SetInt("isInverted", 0);
        SetSfxLvl(sfxSlider.value);
        SetMusicLvl(musicSlider.value);
		Time.timeScale = 1f;
        Back();
    }

    public void SetSfxLvl(float sfxLvl)
    {
        masterMixer.SetFloat("Running", LinearToDecibel(sfxLvl));
    }

	public void SetMusicLvl(float musicLvl)
	{
		masterMixer.SetFloat("BGM", LinearToDecibel(musicLvl));
	}

	private float LinearToDecibel(float linear)
	{
		float dB;

		if (linear != 0)
			dB = 20.0f * Mathf.Log10(linear);
		else
			dB = -144.0f;

		return dB;
	}

	private float DecibelToLinear(float dB)
	{
		float linear = Mathf.Pow(10.0f, dB / 20.0f);

		return linear;
	}
}
