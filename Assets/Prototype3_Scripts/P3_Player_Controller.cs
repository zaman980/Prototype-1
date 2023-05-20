using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_Player_Controller : MonoBehaviour
{

    private Rigidbody playerRb;
    public float jumpforce = 10;
    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {

            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            isOnGround = true;
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {

            gameOver = true;
            Debug.Log("GameOver!");
        }
    }

}
