using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    public GameObject gamobj;

    public GameObject gamobj2;


    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Player")

        {
            if (other.gameObject.tag == "enemy")
            {
                Destroy(this.gamobj);
                Destroy(this.gamobj2);
            }
        }
    }



}