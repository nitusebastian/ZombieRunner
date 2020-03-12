using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float chaseRange = 5f;
    [SerializeField] private bool isProvoked;

    private NavMeshAgent navMeshAgent;
    private float distanceToTarget = Mathf.Infinity;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
            
        if (distanceToTarget <= chaseRange)
        {
            
        }
        
        if(isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }
        
    }

    private void EngageTarget()
    {
        if(distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        
        if(distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void AttackTarget()
    {
        print(transform.name + " has seeked and is destroying ");
    }

    private void ChaseTarget()
    {
        navMeshAgent.SetDestination(target.position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
