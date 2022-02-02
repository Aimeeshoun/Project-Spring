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
        if (other.gameObject.tag == "boxes")
        {
            this_obj = this.gameObject;
            obj_trans = this_obj.transform;
            obj_position = obj_trans.position;
            obj_rotation = obj_trans.rotation;
        }

        if (other.gameObject.tag == "cowww")
        {
            this_obj = this.gameObject;
            obj_trans = this_obj.transform;
            obj_position = obj_trans.position;
            obj_rotation = obj_trans.rotation;

            currentcow__ = Instantiate(currentcow__, obj_position, obj_rotation);
            currentcow__.transform.parent = obj_trans;

        }
    }

}
