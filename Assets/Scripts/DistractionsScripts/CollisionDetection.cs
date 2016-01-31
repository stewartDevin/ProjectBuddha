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
        if(other.tag == "Touch")
        {
            Debug.Log("got here");
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
            
    }
}
