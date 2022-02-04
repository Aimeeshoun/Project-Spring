using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroythecow : MonoBehaviour
{

    public GameObject cow;
    public GameObject cow_;
    public GameObject[] cows;
    public GameObject cow2;

    public GameObject this_gamObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cows = GameObject.FindGameObjectsWithTag("turn in");
     
       
    }

    private void OnTriggerEnter(Collider other)
    {
        this_gamObj = other.gameObject.GetComponentInChildren<GameObject>();

        foreach (GameObject cow_ in cows)
            {
                if (cow.tag == "turn in")
            {
                cow = other.gameObject;

                 //  Destroy(cow);
             //   this_gamObj.SetActive(false);

                }
            }
        }

    
}
