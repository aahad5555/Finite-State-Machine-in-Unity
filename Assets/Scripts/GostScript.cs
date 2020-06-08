using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GostScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject target; //this is the player or a reference for him
    
    NavMeshAgent agent; //this is a reference for the gost navmeshagent component

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        // this is for updating the target location
        agent.destination = target.transform.position;
    }
}
