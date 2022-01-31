using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBoxSize : MonoBehaviour
{

    public GameObject scriptHolder2;
    public GameObject scriptHolder3;
    public BoxCollider the_box;
    public Transform obj_transform;
    public Transform box_transform;
    public Vector3 size_of_box;
    public Vector3 size_of_box3;
    public Vector3 size_of_obj;
    public Vector3 linePoint3;
    public Vector3 linePoint4;
    public LineRenderer Maker_;
    public Vector3 size_of_box2;
    public Quaternion rotation_of_box;


    public GameObject[] boxes;
    public float qx;
    public float qy;
    public float qz;
    public float x;
    public float y;
public float z;

    public float xx;
    public float yy;
    public float zz;


    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scriptHolder2 = GameObject.FindGameObjectWithTag("line2");
        boxes=GameObject.FindGameObjectsWithTag("fence box");

        foreach (GameObject scriptHolder3 in boxes)
        {
            the_box = scriptHolder3.GetComponent<BoxCollider>();
            Maker_ = scriptHolder2.GetComponent<LineRenderer>();
            rotation_of_box=Maker_.transform.rotation;
            size_of_box3 = the_box.size;
            linePoint3 = Maker_.GetPosition(0);
            linePoint4 = Maker_.GetPosition(1);


            x = linePoint3.x;
            y = linePoint3.y;
            z = linePoint3.z;

            xx = linePoint4.x;
            yy = linePoint4.y;
            zz = linePoint4.z;

         // xxx = x - xx;
          //yyy = y - yy;
          //zzz = z - zz;

            box_transform = the_box.transform;
            size_of_box = box_transform.localScale;
            size_of_box2 = box_transform.localPosition;
            obj_transform = this.gameObject.transform;
            size_of_obj = obj_transform.localScale;


         // size_of_box3.x = xxx;
         // size_of_box3.y = yyy;
         // size_of_box3.z = zzz;

      //    the_box.transform.position = new Vector3(x, y, z) / 2; //to get center
            the_box.size = new Vector3(x, y, 0);
        //  the_box.transform.rotation = new Quaternion();
        //  position=the_box.transform.position;
          // position = new Vector3(x, y- yy,z) / 2;
            
        }
     
    }
}
