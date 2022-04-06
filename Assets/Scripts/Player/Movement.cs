using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform player; 
    bool isGrounded = false;
    public static bool jumpSound = false;
    //public LayerMask groundMask;
    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    public float groundDist;
    Vector3 velocity;

    [Header("Values")]
    public float speed = 10f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        groundDist = GetComponent<Collider>().bounds.extents.y; 
    }

    void FixedUpdate() 
    {
        if(!Physics.Raycast(player.position, -Vector3.up, groundDist + 0.1f))
        {
            isGrounded = false; 
        }
        else
        {
            isGrounded = true; 
        }
    }

    void Update()
    {
       Move();
       Jump(); 
    }

    void Move()
    {
        controller.Move(velocity * Time.deltaTime);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    void Jump()
    {
         if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        velocity.y += gravity * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpSound = true;
        }
    }

}