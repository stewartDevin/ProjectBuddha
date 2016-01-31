using UnityEngine;
using System.Collections;

public class Distraction_SetType : MonoBehaviour
{
    GameObject playerGO;
    Player_Stats playerStatsScript;
    Distraction_Stats distractionStatsScript;

    // Use this for initialization
    void Start()
    {
        playerGO = GameObject.Find("Player");
        playerStatsScript = playerGO.GetComponent<Player_Stats>();

        distractionStatsScript = GetComponent<Distraction_Stats>();

        if (playerStatsScript.serenityModeActive)
        {
            gameObject.AddComponent<Distraction_Zent>();
            return;
        }

        int randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {
            gameObject.AddComponent<Distraction_Noise>();
        }
        else if (randomNumber == 2)
        {
            gameObject.AddComponent<Distraction_Projectile>();
        }
        else if (randomNumber == 3)
        {
            gameObject.AddComponent<Distraction_Smell>();
        }
    }
}
