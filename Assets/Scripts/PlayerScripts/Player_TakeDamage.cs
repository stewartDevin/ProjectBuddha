using UnityEngine;
using System.Collections;

public class Player_TakeDamage : MonoBehaviour
{
    Player_Stats playerStatsScript;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "DistractionTrigger")
        {
            Debug.Log("boom");
            playerStatsScript.health--;
            Debug.Log(playerStatsScript.health);
            Destroy(other.transform.parent.gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        playerStatsScript = GameObject.Find("Player").GetComponent<Player_Stats>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
