using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowparent2 : MonoBehaviour
{
    public GameObject[] all_cows;
    public GameObject _cow;

    public GameObject _box;
    public GameObject[] _boxs;

    public ObjectTransform obj_tras_cow;
    public ObjectTransform obj_tras_box;

    public Vector3 pos_cow;
    public Vector3 pos_box;

    public Quaternion rot_cow;
    public Quaternion rot_box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        all_cows = GameObject.FindGameObjectsWithTag("Cowbox");

        _boxs = GameObject.FindGameObjectsWithTag("boxes");


        foreach (GameObject _cow in all_cows)
        {
            obj_tras_cow = _cow.GetComponent<ObjectTransform>();

            pos_cow= obj_tras_cow.obj_position;
            rot_cow= obj_tras_cow.obj_rotation;


        }

        foreach (GameObject box in _boxs)
        {
            obj_tras_box = _cow.GetComponent<ObjectTransform>();
            pos_box= obj_tras_cow.obj_position;
            rot_box= obj_tras_cow.obj_rotation;

        }



    }

}
