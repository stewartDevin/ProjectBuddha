using UnityEngine;
using System.Collections;

public class FollowTouch : MonoBehaviour {

    public float distance = 10;

    float worldScreenHeight;
    float worldScreenWidth;

    // Use this for initialization
    void Start () {
        worldScreenHeight = Camera.main.orthographicSize * 2;
        worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        // for android
#if UNITY_ANDROID && !UNITY_EDITOR
        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            if(myTouch.deltaPosition.x < 5 || myTouch.deltaPosition.y < 5) {
                DisableCollision();        
            } else {
                EnableCollision();
            }

            Vector3 touchPos = new Vector3(myTouch.position.x, myTouch.position.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            Vector3 newPos = ray.GetPoint(distance);

            gameObject.transform.position = newPos;
        } else {
            DisableCollision();
        }
#endif

        // for mouse
#if UNITY_EDITOR
        if(Input.GetMouseButtonUp(0))
        {
            DisableCollision();
        }

        if (Input.GetMouseButton(0))
        {
            EnableCollision();
            Vector3 touchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            Vector3 newPos = ray.GetPoint(distance);

            gameObject.transform.position = newPos;
        }
#endif
    }

    void DisableCollision() {
        gameObject.GetComponentInChildren<Collider2D>().enabled = false;
    }

    void EnableCollision()
    {
        gameObject.GetComponentInChildren<Collider2D>().enabled = true;
    }
}
