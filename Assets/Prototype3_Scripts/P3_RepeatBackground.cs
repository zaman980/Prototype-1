using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_RepeatBackground : MonoBehaviour
{

    private Vector3 startposition;
    private float repeatwidth;
    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
        repeatwidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startposition.x - repeatwidth)
        {

            transform.position = startposition;
        }
    }
}
