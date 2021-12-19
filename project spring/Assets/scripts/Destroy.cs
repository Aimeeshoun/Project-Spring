using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy

        if (gameObject.tag = "Player")
        {
            if (other.tag == "enemy")
            {
                Destroy(gameObject);
            }
        }
                
       
        }
    }
}