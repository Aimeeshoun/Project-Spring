using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoveObj : MonoBehaviour



{

    public GameObject Target;
    public Transform Target_transform_;
    public Vector3 Target_position;
    public Quaternion Target_Vector_;
    public float speed = .1f;
    public float z;
    public float y;
    public float x;


    public GameObject[] Obj_To_move;
    public GameObject Obj_To_movs;
    public Transform obj_transfrom_;
    public Vector3 obj_vector_;
    public Quaternion obj_rotation;

    // Start is called before the first frame update
    void Start()
    {
   
    
    }

    // Update is called once per frame
    void Update()
    {
        Obj_To_move = GameObject.FindGameObjectsWithTag("target");

        Target_transform_ = Target.GetComponent<Transform>();
     

       

     
    }

    public void MoveObjectToSpot()
    {
        //   obj_vector_ = new Vector3(x, y, z);
        //    Obj_To_move.transform.parent = gameObject.transform;



        //    obj_vector_ = new Vector3(x, y, z);
        //     Obj_To_move.transform.parent = Target.transform;
        //      obj_vector_ = Vector3.MoveTowards(obj_vector_, Target_position, Time.deltaTime * speed);
        //    obj_vector_ = new Vector3(0, 0, 0);


        foreach (GameObject Obj_To_movs in Obj_To_move)
        {

            obj_transfrom_ = Obj_To_movs.GetComponent<Transform>();
      //      Target_Vector_ = Target_transform_.rotation;
           Target_position = Target_transform_.position;
      //      obj_rotation = obj_transfrom_.rotation;
      //      obj_vector_ = obj_transfrom_.position;

            z = Target_position.z;
            y = Target_position.y;
            x = Target_position.x;


            obj_vector_ = obj_transfrom_.transform.position = new Vector3(x, y, z);

         //   z = 0;
         //   y = 0;
        //    x = 0;

        }



   



    }

}



