using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public GameObject Target;
    public Transform Target_transform_;
    public Vector3 Target_position2;
    public Vector3 Target_position;
    public Quaternion Target_Vector_;
    public float speed = 5f;

    public float z;
    public float y;
    public float x;
    public float zi;
    public float yi;
    public float xi;
    public GameObject Obj_To_move;
    public Transform obj_transfrom_;
    public Vector3 obj_vector_;
    public Quaternion obj_rotation;
    public GameObject old_gameObj;
    public GameObject newgmeObj;
    public GameObject the_target;
    public Transform _the_target;
    public Vector3 _the_target_pos;



    // Start is called before the first frame update
    public void Start()
    
    {
        Target_transform_ = Target.GetComponent<Transform>();


        _the_target = the_target.GetComponent<Transform>();
        _the_target_pos = _the_target.position;
    }

    // Update is called once per frame
  public void Update()
{


        the_target = GameObject.FindGameObjectWithTag("target");

    float step = speed * Time.deltaTime;
        // transform.position = Vector3.MoveTowards(Target_position,Target_position2, step);

      

    }
  public void Awake()
    {
      

    }


    public void MoveObjectToSpot()
    {

        the_target = GameObject.FindGameObjectWithTag("target");

        Target_Vector_ = Target_transform_.rotation;
        Target_position = Target_transform_.position;
        obj_rotation = obj_transfrom_.rotation;
        obj_vector_ = obj_transfrom_.position;
        z = Target_position.z;
        y = Target_position.y;
        x = Target_position.x;

        zi= obj_vector_.z;
        yi= obj_vector_.y;
        xi= obj_vector_.x;
        // if (Vector3.Distance(Target_position, Target_position2) < 0.001f)
        // {

        //      Target_position *= -1.0f;

        //  }




        //    _the_target_pos = new Vector3(0.0f, 0.0f, 0.0f);




        obj_vector_ = obj_transfrom_.transform.position = new Vector3(x, y, z);
  //    the_target.transform.parent = Target.transform;

  //    Target.transform.DetachChildren();

       zi= 0;
        yi= 0;
       xi= 0;
        //  newgmeObj = Instantiate(the_target, Target_position, Target_Vector_) as GameObject;
        //Destroy(the_target);
        // obj_vector_ = new Vector3(Target_position.x, Target_position.y, Target_position.z);

        // Obj_To_move.transform.parent = gameObject.transform;
        // obj_vector_ = Vector3.MoveTowards(obj_vector_, Target_position, Time.deltaTime * speed);

    }


    
    }
// change scale  Target_position = Target_transform_.transform.localScale = new Vector3(x, y, z); for cow eye 