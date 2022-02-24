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





    public int Timer = 0;


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




    // Update is called once per frame
    public void Update()
    {
        bear = this.gameObject;
        particlessystems_group = GameObject.FindGameObjectsWithTag("particlesystem");
        this_obj_= bear.transform.position;
        other_obj_rotation= bear.transform.rotation;
      //  if (Enemyheath <= 0)
      //  {
   


                //   particle_ = Instantiate(particle_, this_obj_, other_obj_rotation);

          //      BloodSplasts();

              

     //   }     
        
     
       

    }

    public void OnMouseDown()
    {
        Enemyheath -= 1;
    }


    public void BloodSplasts()
    {

    currentBlood__ = Instantiate(currentBlood__, this_obj_, other_obj_rotation);
    currentBlood__.transform.parent = gameObject.transform;
        Destroy(bear,1f);
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

}

