using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    public bool goingRight;
    

    // Update is called once per frame
    void Update()
    {
        //If the laser should move right, move it right, else move it left
        if (goingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    

}
