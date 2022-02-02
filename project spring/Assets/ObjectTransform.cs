using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{

    public GameObject this_obj;
    public Transform obj_trans;
    public Vector3 obj_position;
    public Quaternion obj_rotation;

    public GameObject[] cows_;
    public GameObject[] boxes_;

    public GameObject currentcow__;


    public GameObject other_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        this_obj = this.gameObject;
        obj_trans= this_obj.transform;
        obj_position= obj_trans.position;
        obj_rotation = obj_trans.rotation;




    }

    // Update is called once per frame
    void Update()
    {



}

    private void OnTriggerEnter(Collider other)
    {
        other_obj= other.gameObject;


        if (other_obj.tag == "boxes")
        {
            this_obj = this.gameObject;
            obj_trans = this_obj.transform;
            obj_position = obj_trans.position;
            obj_rotation = obj_trans.rotation;
        }

        if (other_obj.tag == "cowww")
        {
            this_obj = this.gameObject;
            obj_trans = this_obj.transform;
            obj_position = obj_trans.position;
            obj_rotation = obj_trans.rotation;

          //  currentcow__ = Instantiate(currentcow__, obj_position, obj_rotation);
         //   currentcow__.transform.parent = obj_trans;

        }
    }
    public void DestroyObject()
    {
        Destroy(other_obj);
    }
    public void InstanciateCowParent()
    {
        currentcow__ = Instantiate(currentcow__, obj_position, obj_rotation);
        currentcow__.transform.parent = obj_trans;
    }

}