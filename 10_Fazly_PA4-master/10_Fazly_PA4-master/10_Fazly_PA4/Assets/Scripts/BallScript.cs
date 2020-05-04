using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 1;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 5, 0);

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 1) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 250, 0);
        }
    }
}
