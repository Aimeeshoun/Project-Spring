using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    public GameObject gamobj;

    public GameObject gamobj2;


    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Square")

        {
            if (other.gameObject.tag == "Test")
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }



}