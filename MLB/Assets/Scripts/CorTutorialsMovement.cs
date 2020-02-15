using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorTutorialsMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 5f;
    float rotationSpeed = 100f;
    Animator anim;
    [SerializeField] private CharacterController controller;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("Running", true);
            anim.SetFloat("CharacterSpeed", translation);
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetFloat("CharacterSpeed", 0); 
        }

        bool isCrouching = Input.GetAxis("Crouch") > 0f;

        if (isCrouching)
        {
            anim.SetBool("isCrouching", true);
            anim.SetBool("Running", false);
            anim.SetFloat("CharacterSpeed", 0f);
        }
        else
        {
            anim.SetBool("isCrouching", false);
            anim.SetFloat("CharacterSpeed", translation);
        }

        
    }
}
