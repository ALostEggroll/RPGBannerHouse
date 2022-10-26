using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  A class to be attached to the player object. Controls overworld player
 */
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    // Move speed

    public Rigidbody rb;    // Player model

    Vector3 movement;   // Player movement in the world

    // Update is called once per frame
    void Update()
    {
        // Player movement in the x(left and right) direction. Covers A, D, Left key, Right key
        movement.x = Input.GetAxisRaw("Horizontal");

        // Player movement in the z(forward and backward) direction. Covers W, S, Up key, Down key
        movement.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Updates the player model
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
