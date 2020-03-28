using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController controller;


    public float speed = 12f;
    public float gravity = -9.82f;
    public float jumpHeight = 3f;
    public float sprintSpeed;
/*
    private float slideTimer;
    public float slideTime;
    public float slideAngle = 0f;// = 60f;
    public float rotSpeed = 5f;
*/
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Vector3 velocity;
    public bool isGrounded;

    float sprintVel;

    void Awake() {

 
    }

    void Start() {
        sprintVel = speed;
    }


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else {
            speed = sprintVel;
        }

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * h + transform.forward * v;

        velocity.y += gravity * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);

        /*  slideAngle = Mathf.Clamp(slideAngle, 0f, 60f);

          if (Input.GetKey(KeyCode.LeftControl))
          {

              if (slideTime > 0 && Input.GetKey(KeyCode.LeftControl))
              {
                  slideAngle += rotSpeed;
                  transform.localRotation = Quaternion.Euler(0f, 0f, -slideAngle);
                  slideTime -= Time.deltaTime;
              }

              if (slideTime <= 0)
              {
                  slideAngle -= rotSpeed;
                  transform.localRotation = Quaternion.Euler(0f, 0f, slideAngle);

              }

          }

          if (slideAngle <= 0)
          {
              slideAngle = 0;
              slideTime = slideTimer;
          }*/
    }
}

