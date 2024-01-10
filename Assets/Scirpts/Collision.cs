using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        Destroy(gameObject);
        score.scoreValue += 0.5;
    }
    
}
