using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycow : MonoBehaviour
{
    public GameObject[] bears;
    public GameObject bear;
    public InstanciteDeadCow2 _killenemy;
    public GameObject blood;
    public ParticleSystem particleSystem_;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;

    public GameObject particlesystem;

    public GameObject bloodPar_;




    public GameObject blood_;
    public GameObject bear_;
    public bool isDead_;
    public bool ishit_;
    public GameObject deadBear;

    public int timer = 0;
    public int timer2 = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        blood = GameObject.FindGameObjectWithTag("PAR BURGER");
        bears = GameObject.FindGameObjectsWithTag("COW ALIVE");

        isDead_ = _killenemy.cowIsDead;
        particleSystem_ = blood.GetComponent<ParticleSystem>();


        foreach (GameObject bear in bears)
        {
            bear_ = bear;
            //   if (ishit_ == true)
            //   {
            _killenemy = bear_.GetComponent<InstanciteDeadCow2>();
            other_obj_rotation = _killenemy._rotation;
                this_obj_ = _killenemy._postion;
            //    bloodPar_ = Instantiate(particlesystem, this_obj_, other_obj_rotation);
            //    bloodPar_.transform.parent = gameObject.transform;
                
        //    }
          
           
            isDead_ = _killenemy.Cowisdead2;
          //  ishit_ = _killenemy.ishit;
     

            if (isDead_)
            {

                //   this_object = _killenemy.this_object;


                //   _killenemy.BloodSplasts();

              //  deadBear = bear_;
                timer = 1;
                if (timer == 1)
                {
                 //   Destroy(deadBear);
                    timer2 = 1;
                    if (timer2 == 1)
                    {


                        blood_ = Instantiate(blood, this_obj_, other_obj_rotation);
                        blood_.transform.parent = gameObject.transform;
                        timer2 = 0;
                    }

                    timer = 0;
                }


            }

        }

    }
}
