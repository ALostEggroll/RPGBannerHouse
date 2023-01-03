using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*
 *  A class to be attached to a friendly npc. NPC may periodically move. Controls town npcs
 */
 [RequireComponent(typeof(NavMeshAgent))]
public class NPCController : MonoBehaviour
{
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
