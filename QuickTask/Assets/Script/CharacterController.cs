using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public float speed = 20.0f;
    public float horizontalInput;
    public float forwardInput;
    public float verticalInput;
    public bool gameOver = false;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * 10);


        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
    }
    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Spike"))
        {
            gameOver = true;
            Debug.Log("GAME OVER!");
        }
    }
}
