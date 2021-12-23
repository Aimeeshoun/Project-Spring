using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWea1 : MonoBehaviour
{


    private GameObject gamobj;

    private GameObject gamobj2;

   // public Object[] objects;


    
    

        void OnTriggerEnter(Collider other)
        {

            if (other.tag == "wea1")
            {


                {
                    Destroy(this.gameObject);
                    Destroy(other.gameObject);
                }
            }
        }



    }


