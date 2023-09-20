using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    public float speed = 15f;

    public float jumpForce = 5.0f;
    public float gravity = -25.0f;
    Vector3 direction;

    CharacterController controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        
        if (controller.isGrounded)
        {
            direction = new Vector3(hInput, 0f, vInput);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpForce;
                Debug.Log("jump ok");
            }
        }
        direction.y += gravity * Time.deltaTime;
        controller.Move(direction * speed * Time.deltaTime);
    }
}
