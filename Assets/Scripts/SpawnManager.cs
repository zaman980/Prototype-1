using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] AnimalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnRangeZ = 20;

    private float StartDelay = 2;

    private float SpawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            SpawnRandomAnimal();

        }
    }

    void SpawnRandomAnimal()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeZ);
        int animalindex = Random.Range(0, AnimalPrefabs.Length);
        Instantiate(AnimalPrefabs[animalindex], spawnPos, AnimalPrefabs[animalindex].transform.rotation);

    }
}
