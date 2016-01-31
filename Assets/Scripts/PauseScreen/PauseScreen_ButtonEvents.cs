using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScreen_ButtonEvents : MonoBehaviour {

    public GameObject pauseScreenPanel;

    public void OnPauseButtonPressed()
    {
        pauseScreenPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnResumeButtonPressed()
    {
        pauseScreenPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnExitButtonPressed()
    {
        Application.LoadLevel("TitleScreen");
        Time.timeScale = 1f;
    }

    
}
