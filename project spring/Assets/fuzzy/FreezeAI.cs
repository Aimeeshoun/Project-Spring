using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FreezeAI : MonoBehaviour
{
    public NavMeshAgent agent_;
    public GameObject[] bears;
    public GameObject bear;

    public GameObject[] lighting;
    public GameObject lightingchild;
    public Transform lightchildtrans;

    public bool isHit_;
    public ClickFreeze click_;

    public int timer=0;




    private CharacterController _characterController;
    private GameObject this_gameobject;

   
 
  
   
    public bool isStopped_;
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
      
        bears = GameObject.FindGameObjectsWithTag("Fuzzy");
        lighting = GameObject.FindGameObjectsWithTag("WeaponRandomObj");

        foreach (GameObject light in lighting)
        {
            lightingchild = light.transform.GetChild(6).gameObject;

            click_ = lightingchild.GetComponent<ClickFreeze>();
            isHit_ = click_.ishit2;
        }
        foreach (GameObject bear in bears)
        {
          agent_ =bear.GetComponent<NavMeshAgent>();
          //  this_gameobject = bear.gameObject;
     
            isStopped_ = agent_.isStopped;
            agent_.enabled = false;
            agent_.stoppingDistance = .1f;
            if (isHit_)
            {

                timer += 1;
                isStopped_ = agent_.isStopped;
            //    if (timer <= 100)
             //   {


                    agent_ = this_gameobject.GetComponent<NavMeshAgent>();
                    
                    agent_.enabled = false;
                    agent_.stoppingDistance = .1f;
                }
                if (timer >= 100)
                {

                    agent_ = this_gameobject.GetComponent<NavMeshAgent>();
                 
                    agent_.enabled = true;
                    agent_.stoppingDistance = .1f;
                }


            }
        }

    
     
    }


