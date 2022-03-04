using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public int Enemyheath = 6;
    public GameObject bear;
    public int Timer2 = 0;
    public GameObject currentBlood__;
    public GameObject this_gameObject;

    public bool isdead;



    public int Timer = 0;
    public Alienhealth health;
    public int alienhealth_;

    public GameObject particle;
    public ParticleSystem particle_;
    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;


    public particlesystem particleSystem_obj;
    public GameObject[] particlessystems_group;
    public GameObject particlessystems_;
    public bool isdetached;

    public bool ishit;

    public int Timer3;
    public int Timer4;
    public int Timer5;
    public int Timer6;

    public Transform this_object2;
    public Vector3 this_obj_2;
    public Quaternion other_obj_rotation2;


    public void Start()
    {
        isdead = false;
        ishit = false;
    }
    // Update is called once per frame
    public void Update()
    {
        bear = this.gameObject;
        health = bear.GetComponent<Alienhealth>();
        alienhealth_ = health.alienHealth_;
        this_obj_2 = bear.transform.position;
        other_obj_rotation2 = bear.transform.rotation;
        //      particlessystems_group = GameObject.FindGameObjectsWithTag("particlesystem");
        //  Timer3 = 0;
        // Timer4 = 0;

        if (alienhealth_ == 4 || alienhealth_ == 3)
        {
            Timer3 = 1;
            if (Timer3 == 1)
            {
                ishit = true;
            //    Timer3 = 0;
            }



        }
        if (alienhealth_ == 2|| alienhealth_ == 1)
        {
             Timer4 = 1;
        if (Timer4 == 1)
        {
            ishit = true;
             //   Timer4 = 0;
            }


       
           }


        if (Enemyheath <= 0 || alienhealth_ <= 0)
        {
           
            isdead = true;

            //   particle_ = Instantiate(particle_, this_obj_, other_obj_rotation);

            //      BloodSplasts();



            //   }     






        }


    }
    public void OnMouseDown()
     {
         Enemyheath -= 1;
        this_obj_ = bear.transform.position;
        other_obj_rotation = bear.transform.rotation;
        ishit = true;

     }

    public void OnMouseUp()
    {
        ishit = false;
    }

 //  public void BloodSplasts()
  //  {

 //   currentBlood__ = Instantiate(currentBlood__, this_obj_, other_obj_rotation);
  //  currentBlood__.transform.parent = gameObject.transform;
       // Destroy(bear,1f);
        //   particle.transform.DetachChildren();
        //   isdetached = true;
        //  particle_.Emit(100);
        //     Timer = 0;
        //   Destroy(currentBlood__, 9);
        //   DestroyParticles();


        //public void DestroyParticles()
        //  {
        //  foreach (GameObject particlessystems_ in particlessystems_group)
        //    {
        //    Destroy(particlessystems_, 1f);
        //     }
        // }
  

}

