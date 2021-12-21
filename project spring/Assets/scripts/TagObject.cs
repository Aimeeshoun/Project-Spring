using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagObject : MonoBehaviour
{

    void Start()

        gameObject.tag = "Player";
    }

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.tag == "Enemy")
        {
            Debug.Log("Triggered by Enemy");
        }
    }
}
