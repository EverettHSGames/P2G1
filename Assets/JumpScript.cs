using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public CharacterController Char;
    public Transform groundCheck;

    public float groundDistance = 0.4f;
    public float gravity = -9.81f;
    public float jumpHeight = 1;

    bool isGrounded = true;

    public LayerMask groundMask;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        Char.Move(velocity * Time.deltaTime);

        if (isGrounded && velocity.y <= 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;


    }
}
