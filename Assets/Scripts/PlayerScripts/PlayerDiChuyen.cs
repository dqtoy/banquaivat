using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiChuyen : MonoBehaviour
{

    private CharacterController character_Controller;

    private Vector3 move_Direction;

    public float speed = 5f;
    public float gravity = 1f;
    public float acceleration = 1f;
    public float jump_Force = 10f;

    private float vertical_Velocity;

    void Awake()
    {
        character_Controller = GetComponent<CharacterController>();
        Physics.gravity = new Vector3(0, 1f, 0);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        move_Direction = new Vector3(Input.GetAxis(Axis.HORIZONTAL), 0f,
                                     Input.GetAxis(Axis.VERTICAL));

        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        Acceleration();

        character_Controller.Move(move_Direction);
        


    } // move player

    void Acceleration()
    {

        vertical_Velocity -= acceleration * Time.deltaTime;

        Jump();

        move_Direction.y = vertical_Velocity * Time.deltaTime;

    } // apply acceleration

    void Jump()
    {

        if (character_Controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            vertical_Velocity = jump_Force;
        }

    }

} 


































