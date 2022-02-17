using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CowAI : MonoBehaviour


{
    private CharacterController _characterController;
    private GameObject this_gameobject;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform patrolPoint;
    private bool canHunt, canPatrol;
    public GameObject food;
    public Vector3 destination;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        food = GameObject.FindGameObjectWithTag("cow eats food");
        patrolPoint = food.GetComponent<Transform>();
        destination = patrolPoint.position;
        this_gameobject = this.gameObject;
        agent = this_gameobject.GetComponent<NavMeshAgent>();

    }

    public void Update()

    {
        
        destination = patrolPoint.position;
        StartCoroutine(Patrol());
        agent.destination = destination;
        var distance = agent.remainingDistance;
    }

   // private void OnMouseDown()
  //  {
        
 
 //   private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {

            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 1f)) continue;
            yield return new WaitForSeconds(.1f);


        }

    }

}
