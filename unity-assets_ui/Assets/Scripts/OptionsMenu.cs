using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public void Back()
    {
        Debug.Log(PlayerPrefs.GetString("lastScene"));
        SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));
    }
}
