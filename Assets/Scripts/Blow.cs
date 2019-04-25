    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if(GetComponent<Transform>().position.x > other.transform.position.x)
            other.attachedRigidbody.AddForce(Vector3.left * 5);
        else
            other.attachedRigidbody.AddForce(Vector3.left * -5);

        if (GetComponent<Transform>().position.y > other.transform.position.y)
            other.attachedRigidbody.AddForce(Vector3.down * 5);
        else
            other.attachedRigidbody.AddForce(Vector3.down * -5);
    }

}
