using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciateCrisp : MonoBehaviour

{
    public GameObject[] objects_;
    public GameObject object_;
    public GameObject object2_;


    public KillEnemy killenemy_;
    public Transform[] transforms_;
    public Transform transform_;

    public Vector3[] vecs_;
    public Vector3 vec_;

    public Quaternion Quaternion_;
    public Quaternion[] Quaternions;
    public GameObject crispBear;
    public GameObject crispBear2;
    public bool needinfo;
    public bool ishit;

    public bool ishit2;

    public bool istrueee;
    public ClickFreeze click_on_rods;
    public int Timer;

    public bool Bearlit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        objects_ = GameObject.FindGameObjectsWithTag("Fuzzy");
        crispBear = GameObject.FindGameObjectWithTag("crispfuz*");

        click_on_rods = this.gameObject.GetComponent<ClickFreeze>();
        Bearlit = click_on_rods.isCrisp;



        foreach (GameObject object_ in objects_)
        {

            killenemy_ = object_.GetComponent<KillEnemy>();



            transform_ = killenemy_.this_object2;


            vec_ = killenemy_.this_obj_2;

            Quaternion_ = killenemy_.other_obj_rotation2;


            BringCrisp();



        }

       




    }

    public void BringCrisp()
    {
        if (Bearlit)
        {

            Timer = 1;

            if (Timer == 1)
            {
                crispBear2 = Instantiate(crispBear, vec_, Quaternion_) as GameObject;
                //  Destroy(crispBear2, .1f);

            }

            Timer = 0;
        }


    }

}