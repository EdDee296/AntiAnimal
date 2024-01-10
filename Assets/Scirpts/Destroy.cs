using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float bound = 20;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > bound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -7)
        {

            Destroy(gameObject);
            Life.lifeValue++;
        }
        
        
    }
}
