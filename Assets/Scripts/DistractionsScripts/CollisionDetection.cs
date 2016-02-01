using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "DistractionTouchTrigger")
        {
            Destroy(other.transform.parent.gameObject);           
        }

        //switch (other.transform.parent.tag) {
        //    case "Tap":
        //        if (gameObject.tag == "Projectile")
        //            Destroy(gameObject);
        //        break;
        //    case "Swipe":
        //        if (gameObject.tag == "Sound")
        //            Destroy(gameObject);
        //        break;
        //    default:
        //        break;
        //}
            
    }
}
