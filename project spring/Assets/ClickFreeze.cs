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
    public bool needinfo = false;

    // Start is called before the first frame update
    void Start()
    {
        lighting_ = GameObject.FindGameObjectWithTag("lighting");
    }

    // Update is called once per frame
    void Update()
    {
        objects_ = GameObject.FindGameObjectsWithTag("Fuzzy");

        if (needinfo == true)
        {


            foreach (GameObject object_ in objects_)
            {

                killenemy_ = object_.GetComponent<KillEnemy>();



                transform_ = killenemy_.this_object2;


                vec_ = killenemy_.this_obj_2;

                Quaternion_ = killenemy_.other_obj_rotation2;

                lighting_ = Instantiate(lighting_, vec_, Quaternion_) as GameObject;

            }
        }



    }

    private void OnMouseDown()
    {
        needinfo = true;


    }
    private void OnMouseUp()
    {
        needinfo = false;


    }

}