using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiSpeedchange : MonoBehaviour
{
    public GameObject this_bear;
    public NavMeshAgent navMeshAgent;
    public float Speed;
    public float newSpeed;
    public bool isClicked;
    public GameObject grabFreezeholder;
    public FreezeAiNow freeze_;
    

    public void Awake()
    {
        newSpeed = 0f;
        this_bear = this.gameObject;
        navMeshAgent = this_bear.GetComponent<NavMeshAgent>();
        grabFreezeholder = GameObject.FindGameObjectWithTag("freeze holder");
        freeze_ = grabFreezeholder.GetComponent<FreezeAiNow>();
      


    }

    // Update is called once per frame
    public void Update()
    {
        isClicked = freeze_.isclicked3;

        if (isClicked== true)
        {
            navMeshAgent.speed = newSpeed;
        }
       
    }
}
