using UnityEngine;

// Parent class that defines all objects that can be interacted with in the world
// 
public class Interactable : MonoBehaviour
{
    public float radius = 3f; // The distance an object can be interacted with

    // Unity function that draws a sphere wireframe to vizualize interactable distance
    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
