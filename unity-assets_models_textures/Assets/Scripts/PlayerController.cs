using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    public float speed = 15f;

    public float jumpForce = 5.0f;
    public float gravity = -25.0f;
    Vector3 direction;
    public CharacterController controller;
    public Transform player;

    // Use this for initialization
    void Start()
    {
        
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
            }
        }

        if (player.position.y <= -10.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            player.position = new Vector3(player.position.x, player.position.y * 20.0f, player.position.z);
        }
        direction.y += gravity * Time.deltaTime;
        controller.Move(direction * speed * Time.deltaTime);
    }
}