using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowGoldenPath.cs
public class ShowGoldenPath : MonoBehaviour
{
    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform start;
    public Transform POI1;
    public Transform POI2;
    public Transform POI3;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = transform;
        GoToTarget();
    }

    void GoToTarget()
    {
        if(target != transform)
            agent.destination = target.position;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            target = POI1;
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GoToTarget();
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            target = POI2;
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GoToTarget();
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            target = POI3;
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GoToTarget();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            target = start;
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GoToTarget();
        }
    }
}