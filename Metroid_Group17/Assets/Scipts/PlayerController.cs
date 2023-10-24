using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Callanan, Aidan
//10/12/23
//Handles movement and collision for the player

public class PlayerController : MonoBehaviour
{
    public int totalCoins = 0;

    public float speed = 10f;

    public float jumpForce = 10f;

    private Rigidbody rigidbodyRef;

    // Start is called before the first frame update
    void Start()
    {
        //gets the rigidbody component off of this object and stores a reference to it
        rigidbodyRef = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Side to side movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleJump();
        }

        Debug.DrawLine(transform.position, transform.position + Vector3.down * 1.3f, Color.red);
    }

    /// <summary>
    /// Makes the player jump if they are touching the ground
    /// </summary>
    private void HandleJump()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.3f))
        {
            Debug.Log("Player is touching the ground so jump");
            rigidbodyRef.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Player is not touching the ground so they can't jump");
        }


    }

    /// <summary>
    /// Collects any coins
    /// </summary>
    /// <param name="other">The object being collided with</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            totalCoins++;
            other.gameObject.SetActive(false);
        }
    }
}
