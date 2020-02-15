using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    float rotationSpeed = 5.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float vertRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        Quaternion camTurnAngle = Quaternion.AngleAxis(rotation, Vector3.up);
        Quaternion camVertAngle = Quaternion.AngleAxis(vertRotation, Vector3.right);
        

        offset = camTurnAngle * camVertAngle * offset;
        transform.LookAt(player.transform);
    }
}
