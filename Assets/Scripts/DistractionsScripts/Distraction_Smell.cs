using UnityEngine;
using System.Collections;

public class Distraction_Smell : MonoBehaviour {

    Distraction_Stats distractionStatsScript;
    GameObject playerGO;

    // Use this for initialization
    void Start()
    {
        distractionStatsScript = GetComponent<Distraction_Stats>();
        distractionStatsScript.distractionType = Distraction_Stats.DistractionType.Smell;
        distractionStatsScript.moveSpeed = 1.5f;
        Debug.Log("smell incoming");

        playerGO = GameObject.Find("Player");
    }
    
    // Update is called once per frame
    void Update () {
        Vector3 moveDirection = playerGO.transform.position - transform.position;
        moveDirection.z = 0f;
        moveDirection.Normalize();

        transform.position += (moveDirection * distractionStatsScript.moveSpeed) * Time.deltaTime;
        //transform.Translate((transform.position + );
	}
}
