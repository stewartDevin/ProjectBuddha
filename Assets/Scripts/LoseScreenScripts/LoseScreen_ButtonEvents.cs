using UnityEngine;
using System.Collections;

public class LoseScreen_ButtonEvents : MonoBehaviour {

    public GameObject loseScreenPanel;

    public void OnYesButtonPressed()
    {
        Application.LoadLevel("TitleScreen");
        Application.LoadLevel("GameScene");

       // loseScreenPanel.SetActive(false);
    }

    public void OnNoButtonPressed()
    {
        Application.LoadLevel("TitleScreen");

    }
    

	// Use this for initialization
	void Start () {
        GameObject.Find("Player").GetComponent<Player_Death>().OnPlayerDeathEvent += LoseScreen_ButtonEvents_OnPlayerDeathEvent;
	}

    private void LoseScreen_ButtonEvents_OnPlayerDeathEvent()
    {
        loseScreenPanel.SetActive(true);
        GameObject.Find("GameManager").GetComponent<GameManager_SpawnDistractions>().runSpawner = false;
    }

    // Update is called once per frame
    void Update () {
	    
	}
}
