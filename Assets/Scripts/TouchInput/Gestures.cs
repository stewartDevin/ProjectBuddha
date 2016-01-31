using UnityEngine;
using System.Collections;

public class Gestures : MonoBehaviour {

    //NEED TO CALIBRATE
    public float minSwipeDist = 100;
    private Vector2 startPos;

    //Swivel
    private Vector2 pos1;
    private Vector2 pos2;
    private Vector2 pos3;
    private Vector2 vectorDir;


    // Use this for initialization
    void Start () {
        if (Input.touchCount > 0) {
            Touch playerTouch = Input.GetTouch(0);

            switch (playerTouch.phase) {
                case TouchPhase.Began:
                    pos1 = playerTouch.position;
                    break;
                case TouchPhase.Moved:
                    pos2 = playerTouch.position;
                    vectorDir = pos2 - pos1;

                    if (vectorDir.x > 0 && playerTouch.deltaPosition.x < 0 || vectorDir.x < 0 && playerTouch.deltaPosition.x > 0 ||
                        vectorDir.y > 0 && playerTouch.deltaPosition.y < 0 || vectorDir.y < 0 && playerTouch.deltaPosition.y > 0)
                    {
                        //then a change in the direction of the touch has changed
                    }
                    break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0) {
            Touch playerTouch = Input.GetTouch(0);

            switch (playerTouch.phase) {
                case TouchPhase.Began:
                    startPos = playerTouch.position;

                    //if(playerTouch.position is within the trigger of a projectile distraction)
                        //destroy the sound distraction
                    break;
                case TouchPhase.Moved:
                    float swipeDistHorizontal = Vector3.Distance(new Vector3(startPos.x, 0, 0), new Vector3(playerTouch.position.x, 0, 0));
                    float swipeDistVertical = Vector3.Distance(new Vector3(0, startPos.y, 0), new Vector3(0, playerTouch.position.y, 0));
                    Vector2 swipeDist = new Vector2(swipeDistHorizontal, swipeDistVertical);

                    if (swipeDist.magnitude >= minSwipeDist) {
                        //if (swipe enters distraction trigger && is a sound distraction)
                        //Destroy the sound distraction
                        gameObject.transform.position += new Vector3(0.5f, 0, 0) * Time.deltaTime;
                    }

                    break;
            }

        }
	}
}
