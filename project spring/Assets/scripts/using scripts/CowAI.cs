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
    public Transform destination;
    private bool canHunt, canPatrol;
    //  public Transform[] patrolPoints;
    public Transform patrolPoint_;
    public bool isStopped_;
    public GameObject cowEatPoint_;
    public Transform cowTransform;
    public Vector3 position_;


    public GameObject[] eatSpawnPoints;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
     
    }

    public void Update()
    {

        cowEatPoint_ = GameObject.FindGameObjectWithTag("cow eats food");
        
            patrolPoint_ = cowEatPoint_.GetComponent<Transform>();
            position_ = patrolPoint_.position;
        agent.destination = position_;

       
    }

    //private IEnumerator OnTriggerEnter(Collider other)
    //{
    //      canHunt = true;
    //     canPatrol = false;
    //  agent.destination = position_;
    //   var distance = agent.remainingDistance;
    //    while (distance <= 5.25f)
    //  {
    //     distance = agent.remainingDistance;
    //         yield return wffu;
    //    }
    //     yield return new WaitForSeconds(2f);


}
  


