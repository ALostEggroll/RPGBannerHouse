using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*
 *  A class to be attached to the player object. Controls overworld player
 */
 [RequireComponent(typeof(NavMeshAgent))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    // Move speed
    bool facingRight = true;

    public Rigidbody rb;    // Player model
    //public CharacterController controller;
    public Animator animator;
    public NavMeshAgent agent;

    Vector3 movement;   // Player movement in the world

    // Update is called once per frame
    void Update()
    {
        // Player movement in the x(left and right) direction. Covers A, D, Left key, Right key
        //movement.x = Input.GetAxisRaw("Horizontal");

        // Changes sprite based on speed moving horizontally
        //animator.SetFloat("Speed", Mathf.Abs(movement.x));

        // Player movement in the z(forward and backward) direction. Covers W, S, Up key, Down key
       //movement.z = Input.GetAxisRaw("Vertical");

        // Flip character
        //if (movement.x > 0 && !facingRight)
        //{
            //Flip();
        //}
        //if (movement.x < 0 && facingRight)
        //{
            //Flip();
        //}

        // Updates the player model
        //controller.SimpleMove(movement * moveSpeed);
    }

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        // Player movement in the x(left and right) direction. Covers A, D, Left key, Right key
        movement.x = Input.GetAxisRaw("Horizontal");

        // Changes sprite based on speed moving horizontally
        animator.SetFloat("Speed", Mathf.Abs(movement.x));

        // Player movement in the z(forward and backward) direction. Covers W, S, Up key, Down key
        movement.z = Input.GetAxisRaw("Vertical");

        // Flip character
        if (movement.x > 0 && !facingRight)
        {
            Flip();
        }
        if (movement.x < 0 && facingRight)
        {
            Flip();
        }

        //movement.y = rb.velocity.y;
        // Updates the player model
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //rb.velocity = new Vector3(movement.x * moveSpeed, movement.y, movement.z * moveSpeed);
        agent.Move(movement);
    }

    // Controls flipping of character
    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
