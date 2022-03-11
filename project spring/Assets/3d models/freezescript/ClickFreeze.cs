using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFreeze : MonoBehaviour
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
    public GameObject lighting2;
    public bool needinfo;
    public bool ishit;

    public bool ishit2;

    public bool istrueee;
    public ClickonRods click_on_rods;
    public int Timer;

    public bool clickrod;
    public bool isCrisp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        objects_ = GameObject.FindGameObjectsWithTag("Fuzzy");
        lighting_ = GameObject.FindGameObjectWithTag("lightingpar");

        click_on_rods = this.gameObject.GetComponent<ClickonRods>();
        clickrod = click_on_rods.isclickedon;



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
                    isCrisp = true;
                    lighting2 = Instantiate(lighting_, vec_, Quaternion_) as GameObject;

                    Destroy(lighting2, .8f);
                    Destroy(object_, 2f);

                    Timer = 0;
                }

                Timer = 0;
            }



        }






    }


}