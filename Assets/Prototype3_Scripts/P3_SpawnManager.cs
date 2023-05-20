using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_SpawnManager : MonoBehaviour
{

    public GameObject Obstacle_Prefab;

    private float StartDelay = 2;

    private float repeatRate = 2;

    private P3_Player_Controller PlayerControllerScript;

    private Vector3 SpawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn_Obstacle", StartDelay, repeatRate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<P3_Player_Controller>();
    }

    // Update is called once per frame


    void Spawn_Obstacle()
    {
        if (PlayerControllerScript.gameOver == false)
        {

            Instantiate(Obstacle_Prefab, SpawnPos, Obstacle_Prefab.transform.rotation);

        }

    }
}
