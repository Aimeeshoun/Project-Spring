using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detroydeadbears : MonoBehaviour
{
    public GameObject[] bears;
    public GameObject bear;
    public KillEnemy _killenemy;
    public int healthScore;
    //public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject blood;
    public GameObject blood_;
    public GameObject bear_;
    public bool isDead_;
    public bool ishit_;
    public GameObject deadBear;

    public int timer = 0;
    public int timer2 = 0;

    public GameObject particlesystem;
    public ParticleSystem particleSystem_;
    public GameObject bloodPar_;

    // Update is called once per frame
    public void Update()
    {
        blood = GameObject.FindGameObjectWithTag("blooood");
        bears = GameObject.FindGameObjectsWithTag("Fuzzy");
        particlesystem = GameObject.FindGameObjectWithTag("particle blood");
        particleSystem_ = particlesystem.GetComponent<ParticleSystem>();

  
        foreach (GameObject bear in bears)
        {
           
            bear_ = bear;
            _killenemy = bear_.GetComponent<KillEnemy>();
            healthScore = _killenemy.Enemyheath;
            isDead_ = _killenemy.isdead;
            ishit_ = _killenemy.ishit;
            if (ishit_ == true)
            {
                other_obj_rotation = _killenemy.other_obj_rotation;
                this_obj_ = _killenemy.this_obj_;
                bloodPar_ = Instantiate(particlesystem, this_obj_, other_obj_rotation);
                bloodPar_.transform.parent = gameObject.transform;

            }
          
            // if (isDead_)
            //  {
            //   _killenemy.BloodSplasts();
            //      Destroy(bear_);

            //   }

            //   if(healthScore <= 0)
            //  {
            //  _killenemy.BloodSplasts();
     
            if (isDead_)
            {
              
                //   this_object = _killenemy.this_object;
               
             
                //   _killenemy.BloodSplasts();

                deadBear= bear_ ;
                timer = 1;
                if (timer == 1)
                {
                    Destroy(deadBear);
                    timer2 = 1;
                    if (timer2 == 1)
                    {

                        
                        blood_ = Instantiate(blood, this_obj_, other_obj_rotation);
                        blood_.transform.parent = gameObject.transform;
                        timer2 = 0;
                    }

                    timer = 0;
                    Destroy(blood_, 3f);
                }


            }

        }   
 
    }
}
