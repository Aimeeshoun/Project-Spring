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

 //   public bool isHit_;
    public ClickFreeze click_;

    public int timer=0;


    public float speed = 0;

    private CharacterController _characterController;
    private GameObject this_gameobject;


    public float currentSpeed;

    public bool stop1;
 //   public bool isStopped_;
    void Start()
    {

       

    }


    // Update is called once per frame
    void Update()
    {
     
     //   agent_.speed = speed;
        bears = GameObject.FindGameObjectsWithTag("Fuzzy");
        lighting = GameObject.FindGameObjectsWithTag("WeaponRandomObj");

        foreach (GameObject light in lighting)
        {
            lightingchild = light.transform.GetChild(6).gameObject;

            click_ = lightingchild.GetComponent<ClickFreeze>();
           
          
          
        }
        foreach (GameObject bear in bears)
        {
          agent_ =bear.GetComponent<NavMeshAgent>();
            //  this_gameobject = bear.gameObject;
            agent_ = this_gameobject.GetComponent<NavMeshAgent>();
            
         //   currentSpeed = speed;
            
        

            }
        stop1 = click_.istrueee;

    }



}


