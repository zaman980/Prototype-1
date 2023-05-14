using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public GameObject RearLights;

    public float wheelspeed;
    public float turnspeed;

    public List<Transform> wheelpoints;
    public float HorizontalInput;

    public float ForwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        if (ForwardInput < 0)
        {
            RearLights.SetActive(true);
        }
        else
        {

            RearLights.SetActive(false);
        }
        foreach (Transform x in wheelpoints)
        {

            x.Rotate(Vector3.right, Time.deltaTime * wheelspeed * ForwardInput);


        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * HorizontalInput);

    }
}
