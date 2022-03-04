using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFreeze : MonoBehaviour
{
    public GameObject[] objects_;
    public GameObject object_;

  //  public Transform[] transforms_;
    public Transform transform_;

  //  public Vector3[] vecs_;
    public Vector3 vec_;

    public Quaternion Quaternion_;

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
                transform_ = object_.transform;
                vec_ = transform_.position;
                Quaternion_ = transform_.rotation;


            }
        }
    

    }

    private void OnMouseDown()
    {
        needinfo = true;
        FreezeEverything();
    }

    private void OnMouseUp()
    {
        needinfo = false;
    }

    public void FreezeEverything()
    {
        foreach (GameObject object_ in objects_)
        {
          

            lighting_ = Instantiate(lighting_, vec_, Quaternion_) as GameObject;
        }
    }
}
