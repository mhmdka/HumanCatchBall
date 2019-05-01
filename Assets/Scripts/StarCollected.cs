using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StarCollected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Ball":
//                Debug.Break();
                ScoreScript.score += 5;
                Destroy(gameObject);
                break;
        }
    }
}
