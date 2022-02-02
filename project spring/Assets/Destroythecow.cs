using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroythecow : MonoBehaviour
{

    public GameObject cow;

    public GameObject[] cows;
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
        cow=  other.gameObject;
        if(cow.tag == "turn in")
        {
            Destroy(cow);
        }
    }
}
