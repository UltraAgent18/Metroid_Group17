using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(Vector3.up * 90);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.up * 5 * Time.deltaTime);
        }
    }
}
