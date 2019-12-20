using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorTutorialsMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 5f;
    float rotationSpeed = 100f;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
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
    }
}
