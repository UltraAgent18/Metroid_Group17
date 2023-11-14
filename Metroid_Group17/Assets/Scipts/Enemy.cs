using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float travelDistanceRight = 0;
    public float travelDistanceLeft = 0;
    public float speed;
    public int EnemyHealth = 1;

    private float startingX;
    private bool movingRight = true;

    public GameObject EnemyP;

    // Start is called before the first frame update
    void Start()
    {
        //When the scene starts, store the initial x value of this object
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight == true)
        {
            //if the object is not farther than the start position + right travel dist, it can move right
            if (transform.position.x <= startingX + travelDistanceRight)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else
            {
                movingRight = false;
            }
        }
        else
        {
            //If the object is not farther than the start position + left travel dist, it can move left
            if (transform.position.x >= startingX + travelDistanceLeft)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            //If the object goes too far left, tell it to move right
            else
            {
                movingRight = true;
            }
        }

       

        if (EnemyHealth <= 0)
        {
                EnemyP.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            EnemyHealth -= 1;
            
        }
    }
}
