using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to player 

    public float smoothSpeed = 0.125f; // How quickly camera snaps to target
    public Vector3 offset; // Offest camera on all 3 axis
    public Vector3 lookAtOffset = new Vector3(0, 10, 0);

    // Locks camera to target
    void FixedUpdate ()
    {
        // Position we want to snap to
        Vector3 desiredPosition = target.position + offset;
        // Gets closer to desired position
        // Takes in current position, desired position, and smooth speed
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
        // Camera's current position 
        transform.position = smoothedPosition;

        // Camera always looks at player
        // Vector3 lookAtOffset = new Vector3(0, 10, 0);
        transform.LookAt(target.position + lookAtOffset);
    }
}
