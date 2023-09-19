using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    public float speed = 15;

    public float gravity = -60f;
    public float jumpSpeed = 25;
    CharacterController controller;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    // Use this for initialization
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(hInput, 0f, vInput);

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpSpeed;
            }
        }
        direction.y += gravity * Time.deltaTime;
        controller.Move(direction * speed * Time.deltaTime);

        /**
                if (controller.isGrounded)
                {
                    moveVelocity = transform.forward * speed * vInput;

                    if (Input.GetButtonDown("Jump"))
                    {
                        moveVelocity.y = jumpSpeed;
                    }
                }
                //Adding gravity
                moveVelocity.y += gravity * Time.deltaTime;

                controller.Move(moveVelocity * Time.deltaTime);
*/
    }
}