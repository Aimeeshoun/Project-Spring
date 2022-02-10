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
 //   public Vector3 position_food;

 //   public float distance;

   public Vector3 destination;
  
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
     //   Patrol();

        food = GameObject.FindGameObjectWithTag("cow eats food");
        patrolPoint = food.GetComponent<Transform>();
        destination = patrolPoint.position;
        this_gameobject = this.gameObject;
        agent = this_gameobject.GetComponent<NavMeshAgent>();
    
    }
    public void OnAwake()
    {
      
    }
    public void Update()
    {
        destination = patrolPoint.position;
     
        StartCoroutine(Patrol());

        agent.destination = destination;
    }


    private void OnMouseDown()
    {
    //    agent.enabled = true;
        var distance = agent.remainingDistance;
    }
    private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
          
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance <1f)) continue;
            yield return new WaitForSeconds(.1f);
       
      //      agent.stoppingDistance = .1f;
       //     agent.enabled = false;
   

          //  canPatrol = false;
            //     i = (i + 1) % position_s.Length;
       
        
        
   }
     //   agent.stoppingDistance = .1f;
      //  agent.enabled = false;
    }

}

