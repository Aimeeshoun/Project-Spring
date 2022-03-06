using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFreeze1 : MonoBehaviour
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
    public GameObject lighting_;
    public GameObject bigice2;
    public bool needinfo;
    public bool ishit;
    
    public bool ishit2;

    public bool istrueee;
    public ClickonRods click_on_rods;
    public int Timer;

    public bool clickrod;

   
    public GameObject bigIce;


    public ParticleSystem littleicePar;
    public GameObject littleice;
    public GameObject littleice2;
    // Start is called before the first frame update
    public void Start()
    {
        bigIce = GameObject.FindGameObjectWithTag("Big Ice");
        littleice = GameObject.FindGameObjectWithTag("icepar");
    }

    // Update is called once per frame
   public  void Update()
    {

    
        objects_ = GameObject.FindGameObjectsWithTag("Fuzzy");
     

        click_on_rods = this.gameObject.GetComponent<ClickonRods>();
        clickrod=click_on_rods.isclickedon;
        littleicePar = littleice.GetComponent<ParticleSystem>();


        foreach (GameObject object_ in objects_)
        {

            killenemy_ = object_.GetComponent<KillEnemy>();



            transform_ = killenemy_.this_object2;


            vec_ = killenemy_.this_obj_2;

            Quaternion_ = killenemy_.other_obj_rotation2;


            if (clickrod)
            {

                Timer = 1;

                if (Timer == 1)
                {
                    bigice2 = Instantiate(bigIce, vec_, Quaternion_) as GameObject;
                    Destroy(bigice2, .1f);
                    littleice2 = Instantiate(littleice, vec_, Quaternion_) as GameObject;
                    Destroy(littleice2, .1f);
                    Timer = 0;
                }
               
                Timer = 0;
            }



        }
         
            

      

       
    }


}