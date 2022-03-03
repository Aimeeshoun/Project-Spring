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
    // Start is called before the first frame update
    void Start()
    {

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
            bloodPar_.transform.parent = gameObject.transform;
        }




    }

}



 
      