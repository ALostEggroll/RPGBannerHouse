using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  A class to be attached to the player object. Controls overworld player
 */
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Player goes up
            Debug.Log("Player is going up");
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Player goes left
            Debug.Log("Player is going left");
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Player goes down
            Debug.Log("Player is going down");
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Player goes right
            Debug.Log("Player is going right");
        }
    }
}
