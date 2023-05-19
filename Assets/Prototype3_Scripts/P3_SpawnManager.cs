using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_SpawnManager : MonoBehaviour
{

    public GameObject Obstacle_Prefab;

    private float StartDelay = 2;

    private float repeatRate = 2;

    private Vector3 SpawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn_Obstacle", StartDelay, repeatRate);
    }

    // Update is called once per frame


    void Spawn_Obstacle()
    {

        Instantiate(Obstacle_Prefab, SpawnPos, Obstacle_Prefab.transform.rotation);

    }
}
