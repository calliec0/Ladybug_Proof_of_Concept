using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float verticalForce;
    public float horizontalForce;
    public float forwardForce;
    public float backwardsForce;
    public float turnSpeed;
    private int jumps;

    void Start() { }

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        // adding vertical force 
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Keypad6))
        {
            rb.AddRelativeForce(horizontalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Keypad4))
        {
            rb.AddRelativeForce(-horizontalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Keypad8))
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Keypad5))
        {
            rb.AddRelativeForce(0, 0, -backwardsForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Keypad7))
        {
            rb.AddTorque(0, -turnSpeed, 0);
        }

        if (Input.GetKey(KeyCode.Keypad9))
        {
            rb.AddTorque(0, turnSpeed, 0);
        }
    }
}
