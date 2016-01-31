using UnityEngine;
using System.Collections;

public class Player_Death : MonoBehaviour {

    bool isDead = false;
    private Player_Stats playerStatsScript;

    public delegate void OnPlayerDeathDelegate();
    public event OnPlayerDeathDelegate OnPlayerDeathEvent;
    public void Trigger_OnPlayerDeathEvent() { if (OnPlayerDeathEvent != null) OnPlayerDeathEvent(); }

	// Use this for initialization
	void Start () {
        playerStatsScript = GetComponent<Player_Stats>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(!isDead && playerStatsScript.health <= 0)
        {
            Trigger_OnPlayerDeathEvent();
            isDead = true;
        }
	}
}
