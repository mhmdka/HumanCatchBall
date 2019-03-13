using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerStay(Collider other)
    {
        
        other.attachedRigidbody.AddForce(Vector3.left * 10);
    }

    //void CastRayToWorld()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    Vector3 point = ray.origin + (ray.direction);
    //    Debug.Log("World point is " + point);
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("ObjectFound");
    //}

}
