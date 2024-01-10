using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", 0, 1.5f);
    }

    void SpawnRandom()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 loc = new Vector3(Random.Range(-20, 20), 0, 20);
        Instantiate(animalPrefabs[animalIndex], loc, animalPrefabs[animalIndex].transform.rotation);
    }
}
