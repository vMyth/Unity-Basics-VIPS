using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}

