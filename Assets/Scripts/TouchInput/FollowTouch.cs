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
        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Vector3 touchPos = new Vector3(myTouch.position.x, myTouch.position.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPos);
            Vector3 newPos = ray.GetPoint(distance);

            gameObject.transform.position = newPos;
        }       
    }
}
