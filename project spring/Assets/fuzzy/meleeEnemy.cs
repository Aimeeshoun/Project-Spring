using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemy : MonoBehaviour
{
    public GameObject oth_gameObject;
    public KillEnemy killScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit(Collider other)
    {

        oth_gameObject = other.gameObject;
        if (oth_gameObject.tag == ("Fuzzy"))
            {

             }
    }
}
