using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision col) {

        if (col.rigidbody.velocity.magnitude < 2)
        {
            ScoreScript.score += 10;
        }
        else if (col.rigidbody.velocity.magnitude == 0 || col.rigidbody.velocity.magnitude >= 1)
        {
            Destroy(col.gameObject);
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
