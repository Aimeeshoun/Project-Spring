using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aibehavior : MonoBehaviour
{
    private CharacterController _characterController;
    private GameObject this_gameobject;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform destination;
    private bool canHunt, canPatrol;
    public List<Transform> patrolPoints;
    public bool isStopped_;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = destination.position;
        var distance = agent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }
        yield return new WaitForSeconds(2f);

        StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }
    private void OnMouseDown()
    {
        this_gameobject= this.gameObject;
        agent = this_gameobject.GetComponent<NavMeshAgent>();
       // isStopped_ = agent.isStopped;
        agent.enabled = false;
        agent.stoppingDistance = .1f;                                                                                                

    }
  
    private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            yield return new WaitForSeconds(1);
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
