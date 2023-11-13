using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
    public GameObject TimerCanvas; 
    public GameObject CutsceneCamera;
    void Enabled()
    {
        Camera.SetActive(true);
        Player.GetComponent<PlayerController>().enabled = true;
        TimerCanvas.SetActive(true);
        CutsceneCamera.SetActive(false);
    }

}
