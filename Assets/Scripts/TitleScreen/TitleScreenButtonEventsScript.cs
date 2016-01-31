using UnityEngine;
using System.Collections;

public class TitleScreenButtonEventsScript : MonoBehaviour {
    
    public void OnStartButtonPressed()
    {
        Application.LoadLevel("GameScene");
    }

    public void OnExitButtonPressed()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    
}
