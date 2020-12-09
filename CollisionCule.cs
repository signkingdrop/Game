using UnityEngine;
using System.Collections;

public class CollisionCule : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name != "Plane")
        {
            Debug.Log("Collision on..." + coll.gameObject.name);
        }

    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.name != "Plane")
        {
            Debug.Log("Collision exit..." + coll.gameObject.name);
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            Debug.Log("Collision stay..." + collision.gameObject.name);
        }

    }
}
