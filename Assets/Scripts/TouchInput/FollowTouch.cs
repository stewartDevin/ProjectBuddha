using UnityEngine;
using System.Collections;

public class FollowTouch : MonoBehaviour {

    private bool isTouching = false;

    public SpriteRenderer city;
    public SpriteRenderer mountain;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            city.enabled = true;
            mountain.enabled = false;
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            city.enabled = false;
            mountain.enabled = true;
        }


    }
}
