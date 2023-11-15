/*
 * OptionsMenu Script
 * ------------------
 * This script manages the options menu functionality in a Unity game. It allows players to customize settings
 * such as inverting the Y-axis, adjusting sound effects (SFX) volume, and adjusting background music (BGM) volume.
 * The script uses Unity's UI components, AudioMixer for audio control, and PlayerPrefs for data persistence.
 * 
 * Public Variables:
 *  - Toggle InvertY: Represents the toggle button for inverting the Y-axis.
 *  - AudioMixer masterMixer: Reference to the AudioMixer to control audio settings.
 *  - GameObject buttonRollover: Reference to the GameObject containing the audio source for button rollover sound.
 *  - GameObject buttonClick: Reference to the GameObject containing the audio source for button click sound.
 *  - Slider sfxSlider: Represents the slider for adjusting SFX volume.
 *  - Slider musicSlider: Represents the slider for adjusting BGM volume.
 *  - AudioMixerSnapshot unpaused: Represents an AudioMixerSnapshot for transitioning audio when unpausing.
 * 
 * Methods:
 *  - Start(): Called when the script is first initialized. Retrieves and applies player preferences for inversion status,
 *    SFX volume, and BGM volume.
 *  - Back(): Invoked when the user clicks the "Back" button. Transitions audio to the unpaused state, sets SFX and BGM
 *    levels, sets time scale to 1, and loads the last scene.
 *  - Apply(): Invoked when the user clicks the "Apply" button. Saves inversion status, SFX volume, and BGM volume to
 *    PlayerPrefs, sets SFX and BGM levels, sets time scale to 1, and calls Back() to load the last scene.
 *  - SetSfxLvl(float sfxLvl): Sets the SFX volume in the AudioMixer and adjusts button rollover and click sound volumes.
 *  - SetMusicLvl(float musicLvl): Sets the BGM volume in the AudioMixer.
 *  - LinearToDecibel(float linear): Converts a linear volume value to decibels.
 *  - DecibelToLinear(float dB): Converts a decibel volume value to linear.
 * 
 * Usage:
 *  1. Attach this script to a GameObject in the Options menu scene.
 *  2. Link UI elements (Toggle, Sliders, etc.) and AudioMixer in the Inspector.
 *  3. Customize audio snapshots and references to match the game's audio setup.
 *  4. Ensure that PlayerPrefs keys are consistent with other scripts if used for cross-script communication.
 * 
 * Notes:
 *  - This script assumes the existence of certain PlayerPrefs keys for data persistence.
 *  - Make sure to configure the AudioMixer in the Unity Editor according to the game's audio setup.
 *  - Adjust the script as needed to fit specific project requirements or integrate additional features.
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
	public Toggle InvertY;
	public AudioMixer masterMixer;
	public GameObject buttonRollover;
	public GameObject buttonClick;
	public Slider sfxSlider;
	public Slider musicSlider;
	public AudioMixerSnapshot unpaused;

	public void Start()
	{
		if (PlayerPrefs.GetInt("isInverted") == 1)
			InvertY.isOn = true;
		else
			InvertY.isOn = false;
		Setup();
		
	}

	public void Setup()
	{
		sfxSlider.value = PlayerPrefs.GetFloat("sfxSlider", 1f);
		SetSfxLvl(sfxSlider.value);
		musicSlider.value = PlayerPrefs.GetFloat("musicSlider", 1f);
		SetMusicLvl(musicSlider.value);
	}

	public void Back()
	{
		unpaused.TransitionTo(0.000001f);
		SetSfxLvl(sfxSlider.value);
		SetMusicLvl(musicSlider.value);
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
		PlayerPrefs.SetFloat("sfxSlider", sfxSlider.value);
		SetMusicLvl(musicSlider.value);
		PlayerPrefs.SetFloat("musicSlider", musicSlider.value);
		Time.timeScale = 1f;
		Back();
	}

	public void SetSfxLvl(float sfxLvl)
	{
		masterMixer.SetFloat("Running", LinearToDecibel(sfxLvl));
		masterMixer.SetFloat("Ambience", LinearToDecibel(sfxLvl));
		buttonRollover.GetComponent<AudioSource>().volume = LinearToDecibel(sfxLvl);
		buttonClick.GetComponent<AudioSource>().volume = LinearToDecibel(sfxLvl);
	}

	public void SetMusicLvl(float musicLvl)
	{
		masterMixer.SetFloat("BGM", LinearToDecibel(musicLvl));
	}

	public float LinearToDecibel(float linear)
	{
		float dB;

		if (linear != 0)
			dB = 20.0f * Mathf.Log10(linear);
		else
			dB = -144.0f;

		return dB;
	}

	public float DecibelToLinear(float dB)
	{
		float linear = Mathf.Pow(10.0f, dB / 20.0f);

		return linear;
	}
}
