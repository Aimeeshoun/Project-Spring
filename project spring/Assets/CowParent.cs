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







    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;
    public GameObject this_gameObject;
    public GameObject[] all_cows;
    public GameObject[] _cow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        all_cows = GameObject.FindGameObjectsWithTag("COW ALIVE");

        foreach(GameObject _cow in all_cows)
        {
            this_obj_ = this_object.position;
            other_obj_rotation = this.gameObject.transform.rotation;
            this_object = this_gameObject.transform;

        }

       

    }

    private void OnTriggerEnter(Collider other)
    {
        other_gameObject_ = other.gameObject;
        if (other.tag == "boxes")
        {
            Destroy(this_gameObject);
            InstanciateCowParent();


        }
    }

    public void DestroyObject()
    {
        Destroy(this_gameObject);
    }

    public void InstanciateCowParent()
    {
        currentcow__ = Instantiate(currentcow__, this_obj_, other_obj_rotation);
        currentcow__.transform.parent = other_gameObject_.transform;
    }
}
