using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  A class to be attached to the player object. Controls overworld player
 */
public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;    // Player model
    public float moveSpeed;    // Move speed
    //public CharacterController controller;
    //public Animator animator;

    bool facingRight = true;
    private Vector3 moveInput;   // Player movement in the world

    // Update is called once per frame
    void Update()
    {
        // Player movement in the x(left and right) direction. Covers A, D, Left key, Right key
        moveInput.x = Input.GetAxisRaw("Horizontal");
        // Player movement in the z(forward and backward) direction. Covers W, S, Up key, Down key
        moveInput.z = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        // Changes sprite based on speed moving horizontally
        //animator.SetFloat("Speed", Mathf.Abs(movement.x));

        // Updates the player model
        rb.velocity = new Vector3(moveInput.x * moveSpeed, rb.velocity.y, moveInput.z * moveSpeed);

        // Flip character
        if (moveInput.x > 0 && facingRight)
        {
            Flip();
        }
        if (moveInput.x < 0 && !facingRight)
        {
            Flip();
        }

        // Updates the player model
        //controller.SimpleMove(controller.center + moveInput * moveSpeed);
    }

    void FixedUpdate()
    {
        // Updates the player model
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
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
