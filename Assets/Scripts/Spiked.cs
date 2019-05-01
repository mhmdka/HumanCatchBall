using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiked : MonoBehaviour
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
                ScoreScript.score -= 25;
                print("ridi");
                Destroy(other.gameObject);
                break;
        }
    }
    
}
