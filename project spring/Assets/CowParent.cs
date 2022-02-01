using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowParent : MonoBehaviour
{

    public int Timer = 0;
    public int Timer2 = 0;



    public GameObject currentcow__;
    /// 
    public float spawnRate;


    public BoxTag boxTag_;
    public CowTag cowTag_;

    public GameObject boxtag;
    public GameObject cowtag;

    public GameObject boxtag2;
    public GameObject cowtag2;

    public Transform box_transform;
    public Transform cow_transfrom;

    public Vector3 box_Vec;
    public Vector3 cow_vec;

    public Quaternion box_rotation;
    public Quaternion cow_rotation;




    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;
    public GameObject this_gameObject;
    public GameObject[] all_cows;
    public GameObject[] _cow;


    public GameObject destroybox;
    public GameObject[] destroyboxs;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      //destroybox = GameObject.FindGameObjectWithTag("Cowbox");


        all_cows = GameObject.FindGameObjectsWithTag("Cowbox");
   
        destroyboxs = GameObject.FindGameObjectsWithTag("boxes");
      
   
   
        foreach (GameObject _cow in all_cows)
        {
            boxTag_ = _cow.GetComponent<BoxTag>();
            boxtag2 = boxTag_.other_gamobj; 

            if (boxTag_.other_gamobj.tag == "boxes")
            {
                boxTag_ = _cow.GetComponent<BoxTag>();
                boxtag2 = boxTag_.other_gamobj;
                box_transform = boxtag2.transform;
                box_Vec = box_transform.position;
                box_rotation = box_transform.rotation;
               


                    Destroy(cowtag2);
                    InstanciateCowParent();


            }
         

        }

 foreach (GameObject box in destroyboxs)
        {
            cowTag_ = box.GetComponent<CowTag>();
            cowtag2 = cowTag_.other_gamobj;
            cow_transfrom = cowtag2.transform;
            cow_vec = cow_transfrom.position;
            cow_rotation = cow_transfrom.rotation;
        }



    }

    public void DestroyObject()
    {
        Destroy(cowtag2);
    }

    public void InstanciateCowParent()
    {
        currentcow__ = Instantiate(currentcow__, box_Vec, box_rotation);
        currentcow__.transform.parent = boxtag2.transform;
    }
}
