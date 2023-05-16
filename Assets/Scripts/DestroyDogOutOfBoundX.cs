using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDogOutOfBoundX : MonoBehaviour
{

    private float Xrange = -45;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < Xrange)
        {
            Destroy(gameObject);
        }
    }
}
