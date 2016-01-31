using UnityEngine;
using System.Collections;

public class Gestures : MonoBehaviour
{

    //NEED TO CALIBRATE
    public float minSwipeDist;
    private Vector2 startPos;

    //Swivel
    private Vector2 currentPos;
    private Vector2 lastPos;
    private Vector2 vectorDir;
    float worldScreenHeight;
    float worldScreenWidth;


    // Use this for initialization
    void Start()
    {
        worldScreenHeight = Camera.main.orthographicSize * 2;
        worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
        minSwipeDist = worldScreenWidth / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch playerTouch = Input.GetTouch(0);
            currentPos = playerTouch.position;

            switch (playerTouch.phase)
            {
                case TouchPhase.Began:
                    startPos = playerTouch.position;

                    //if(playerTouch.position is within the trigger of a projectile distraction)
                    //destroy the sound distraction
                    break;
                case TouchPhase.Moved:
                    ////SWIPE
                    //float swipeDist = (playerTouch.position - startPos).magnitude;

                    //if (swipeDist > minSwipeDist)
                    //{
                    //    //if (swipe enters distraction trigger && is a sound distraction)
                    //    //Destroy the sound distraction
                    //    gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                    //}
                    ////END SWIPE

                    //SQUIGGLE
                    lastPos = currentPos - playerTouch.deltaPosition;
                    vectorDir = lastPos - currentPos;

                    //if (vectorDir is pointing to the right and the change in position is to the left)
                    //if ((vectorDir.x > 0 && playerTouch.deltaPosition.x < 0) || (vectorDir.x < 0 && playerTouch.deltaPosition.x > 0) ||
                    //    (vectorDir.y > 0 && playerTouch.deltaPosition.y < 0) || (vectorDir.y < 0 && playerTouch.deltaPosition.y > 0))
                    if (vectorDir.x > 0 && playerTouch.deltaPosition.x < 0)
                    {
                        //then a change in the direction of the touch has changed
                        gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                    }
                    else if (playerTouch.phase == TouchPhase.Ended) {
                        return;
                    }
                    //END OF SQUIGGLE

                    break;
            }

        }

        if (Input.touchCount > 0)
        {
            Touch playerTouch = Input.GetTouch(0);
            currentPos = playerTouch.position;

            if (playerTouch.phase == TouchPhase.Moved)
            {
                lastPos = currentPos - playerTouch.deltaPosition;
                vectorDir = lastPos - currentPos;

                //if (vectorDir is pointing to the right and the change in position is to the left)
                //if ((vectorDir.x > 0 && playerTouch.deltaPosition.x < 0) || (vectorDir.x < 0 && playerTouch.deltaPosition.x > 0) ||
                //    (vectorDir.y > 0 && playerTouch.deltaPosition.y < 0) || (vectorDir.y < 0 && playerTouch.deltaPosition.y > 0))
                if (vectorDir.x > 0 && playerTouch.deltaPosition.x < 0)
                {
                    //then a change in the direction of the touch has changed
                    gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                }
            }
            else if (playerTouch.phase == TouchPhase.Ended)
            {
                return;
            }
        }
    }
}
