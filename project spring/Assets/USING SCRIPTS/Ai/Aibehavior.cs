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

        if (eatSpawnPoints.Length > 0)
        {
            foreach (GameObject cowEatPoint_ in eatSpawnPoints)
            {
                patrolPoint_ = cowEatPoint_.GetComponent<Transform>();
                position_ = patrolPoint_.position;
           

            }

        }

   
  
    }

    private IEnumerator OnTriggerEnter(Collider other)


    {
        var distance = agent.remainingDistance;

        if (distance > 0.00f)
        {

            canHunt = true;
            canPatrol = false;
            if(eatSpawnPoints.Length > 0)
            {
                agent.destination = position_;

                while (distance <= 0.25f)
                {
                 //   distance = agent.remainingDistance;
                    yield return wffu;
                }
                yield return new WaitForSeconds(2f);

                StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
            }


        }
    
    }


  
   // private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            yield return new WaitForSeconds(2);
            agent.destination = position_;

        }
    }
}
