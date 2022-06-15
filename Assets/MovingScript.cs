using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 4f;
    public float rotAngle = 3.0f;

  




    private Rigidbody rb;
    public CharacterController Char;

    Vector3 velocity;





    public float normalspd = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() 
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Char.Move(move * normalspd * Time.deltaTime);


    }
}