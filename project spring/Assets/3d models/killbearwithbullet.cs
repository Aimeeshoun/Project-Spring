using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbearwithbullet : MonoBehaviour
{


    public GameObject bear;

    public GameObject Particlebld;

    public GameObject NewPar;
    // Start is called before the first frame update
    void Start()
    {
        Particlebld = GameObject.FindGameObjectWithTag("bulletblood");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        bear=  other.gameObject;
       
        if(other.tag == ("Fuzzy"))

        {

            NewPar = Instantiate(Particlebld, bear.transform.position, bear.transform.rotation) as GameObject;
            Destroy(other.gameObject);
            Destroy(NewPar, 3f);
        }
    }
}
