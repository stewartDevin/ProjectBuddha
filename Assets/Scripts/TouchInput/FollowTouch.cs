using UnityEngine;
using System.Collections;

public class FollowTouch : MonoBehaviour {

    public float distance = 10;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        // for android
#if UNITY_ANDROID && !UNITY_EDITOR
        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Vector3 touchPos = new Vector3(myTouch.position.x, myTouch.position.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            Vector3 newPos = ray.GetPoint(distance);

            gameObject.transform.position = newPos;
        }   
#endif

        // for mouse
#if UNITY_EDITOR
        if(Input.GetMouseButton(0))
        {
           
            Vector3 touchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            Vector3 newPos = ray.GetPoint(distance);

            gameObject.transform.position = newPos;
        }
#endif
    }
}
