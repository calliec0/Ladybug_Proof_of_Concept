using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public Rigidbody rb;
    public CharacterController controller;
    public MeshCollider playerCollider;
    public Vector3 forwardMoveSpeed;
    public Vector3 backwardMoveSpeed;
    public Vector3 strafeMoveSpeed;

    public UnityEditor.Animations.AnimatorController playerAnimatorController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxis("Vertical") > 0)
        {
            if (playerAnimatorController.parameters[0].defaultBool == false)
            {
                AnimatorControllerParameter[] parameters = playerAnimatorController.parameters;
                parameters[0].defaultBool = true;
                playerAnimatorController.parameters = parameters;
            }
            controller.Move(forwardMoveSpeed);
            
        } else if(Input.GetAxis("Vertical") < 0)
        {
            controller.Move(backwardMoveSpeed);
            AnimatorControllerParameter[] parameters = playerAnimatorController.parameters;
            parameters[0].defaultBool = false;
            playerAnimatorController.parameters = parameters;
        } else
        {
            AnimatorControllerParameter[] parameters = playerAnimatorController.parameters;
            parameters[0].defaultBool = false;
            playerAnimatorController.parameters = parameters;
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            controller.Move(strafeMoveSpeed);
            controller.gameObject.transform.Rotate(0, 90*Time.deltaTime, 0, Space.Self);
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            controller.Move(-strafeMoveSpeed);
            controller.gameObject.transform.Rotate(0, -90 * Time.deltaTime, 0, Space.Self);
        }

    }
}
