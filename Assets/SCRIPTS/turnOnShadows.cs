using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnShadows : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //attach this to any sprite to enable shadow casting and recieve shadows without going into debug
        GetComponent<SpriteRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        GetComponent<SpriteRenderer>().receiveShadows = true;
    }
}
