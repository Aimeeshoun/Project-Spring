using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowParent : MonoBehaviour
{

    public int Timer = 0;
    public int Timer2 = 0;
    public GameObject cows_;



    public GameObject currentcow__;
    /// 
    public float spawnRate;

 





    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;

   

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boxes")
        {
            Timer = 1;

         if (Timer == 1)
            {
                Timer2= 1;
                if (Timer2 == 1)
                {
                    currentcow__ = Instantiate(currentcow__, this_obj_, other_obj_rotation);
                    Timer2 = 0;
                }
            
                currentcow__.transform.parent = other.gameObject.transform;
               

            }
            Destroy(this.gameObject);

        }
    }

}
