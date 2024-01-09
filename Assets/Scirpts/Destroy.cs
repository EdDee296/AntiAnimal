using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float bound = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -bound)
        {

            Destroy(gameObject);
            
        }
        
    }
}
