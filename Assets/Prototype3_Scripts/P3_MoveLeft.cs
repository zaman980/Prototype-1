using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_MoveLeft : MonoBehaviour
{

    private float speed = 30;

    private float leftbound = -15;

    private P3_Player_Controller playercontrollerscript;
    // Start is called before the first frame update
    void Start()
    {
        playercontrollerscript = GameObject.Find("Player").GetComponent<P3_Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrollerscript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }

        if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
