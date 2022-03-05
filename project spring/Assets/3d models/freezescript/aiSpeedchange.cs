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
    public float oldSpeed;


    public void Awake()
    {

        newSpeed = 0f;
        this_bear = this.gameObject;
        navMeshAgent = this_bear.GetComponent<NavMeshAgent>();
        grabFreezeholder = GameObject.FindGameObjectWithTag("freeze holder");
        freeze_ = grabFreezeholder.GetComponent<FreezeAiNow>();
        oldSpeed = navMeshAgent.speed;



    }

    // Update is called once per frame
    public void Update()
    {
        isClicked = freeze_.isclicked3;

        if (isClicked == true)
        {
            StartCoroutine(Freeze3());
            Freeze3();

        }


        IEnumerator Freeze3()
        {
            //Print the time of when the function is first called.
            navMeshAgent.speed = newSpeed;

            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(5);

            //After we have waited 5 seconds print the time again.
            navMeshAgent.speed = oldSpeed;

        }
    }
}
