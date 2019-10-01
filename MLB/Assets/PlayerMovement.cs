﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float verticalForce;
    public float horizontalForce;
    public float forwardForce;
    public float backwardsForce;

    void Start() { }

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        // adding vertical force 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)) 
        { 
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0); 
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -backwardsForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddTorque(0, 10, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb.AddTorque(0, -10, 0);
        }
    }
}
