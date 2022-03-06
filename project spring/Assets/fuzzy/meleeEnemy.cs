using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemy : MonoBehaviour
{
    public GameObject oth_gameObject;
    public KillEnemy killScript;

    public GameObject particlesystem;
    public ParticleSystem particleSystem_;
    public GameObject bloodPar_;

    public Transform transform_;
    public Quaternion other_obj_rotation;
    public Vector3 this_obj_;


    public GameObject otherbear;
    public bool ishit_;

    public GameObject deadbear;
    public GameObject deadbear2;
    public int Timer;

    // Start is called before the first frame update
    void Start()
    {
        deadbear = GameObject.FindGameObjectWithTag("dead fuz");
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {


        particlesystem = GameObject.FindGameObjectWithTag("particle blood");
        particleSystem_ = particlesystem.GetComponent<ParticleSystem>();
    }


    private void OnTriggerEnter(Collider other)
    {
        oth_gameObject = other.gameObject;

        if (oth_gameObject.tag == ("Fuzzy"))
        {
            transform_ = oth_gameObject.transform;
            other_obj_rotation = transform_.rotation;
            this_obj_ = transform_.position;
            bloodPar_ = Instantiate(particlesystem, this_obj_, other_obj_rotation);

            if (oth_gameObject.tag == ("Fuzzy"))


            {

               
                otherbear = oth_gameObject;
                killScript=otherbear.GetComponent<KillEnemy>();
                ishit_ = killScript.isdeadnow;
                if (ishit_)
                {
                    Timer = 1;
                    if(Timer == 1)
                    {

                        deadbear2 = Instantiate(deadbear, this_obj_, other_obj_rotation);
                     // deadbear2.transform.parent = gameObject.transform;
                        Destroy(deadbear2, 3f);
                        Timer = 0;
                    }
                    Timer = 0;


                }
               
            }
            
        
        }




    }

}



 
      