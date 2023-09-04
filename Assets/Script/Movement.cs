using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField] Transform targetA;
    [SerializeField] Transform targetB;
    [SerializeField] Transform targetC;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){ agent.SetDestination(targetA.position); }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){ agent.SetDestination(targetB.position); }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){ agent.SetDestination(targetC.position); }
    }
}
