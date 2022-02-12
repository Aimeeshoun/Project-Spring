using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aibehavior : MonoBehaviour
{

    private GameObject this_gameobject;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;

    private bool canHunt, canPatrol;

   public Transform patrolPoint_;
    public bool isStopped_;

    public Vector3 position_;
    public Vector3[] position_s;

    public GameObject[] eatSpawnPoints;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
        Patrol();
    }

    public void Update()
    {
        
        eatSpawnPoints = GameObject.FindGameObjectsWithTag("eat cow point");
        foreach (GameObject cowEatPoint_ in eatSpawnPoints)
        {
            patrolPoint_ = cowEatPoint_.GetComponent<Transform>();
            position_ = patrolPoint_.position;
            position_s[0] = position_;
            
        }
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = position_;
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
        isStopped_ = agent.isStopped;
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
            yield return new WaitForSeconds(2);
            agent.destination = position_s[0];

        }
    }
}
