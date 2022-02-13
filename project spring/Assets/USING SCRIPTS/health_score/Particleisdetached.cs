using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particleisdetached : MonoBehaviour
{

    public killfuzzy killfuzzy_;
    public bool isdetached2;
    public bool isdetached3;
    public GameObject killFuzz;
    public GameObject[] KillFuzzes;


    // Start is called before the first frame update
    public void Start()
    {
        KillFuzzes=GameObject.FindGameObjectsWithTag("Fuzzy");
        foreach (GameObject killFuzz in KillFuzzes)
        {
            killfuzzy_ = killFuzz.GetComponent<killfuzzy>();

         
        }
        isdetached2 = false;
        isdetached3 = false;
    }
    // Update is called once per frame
    public void Update()
    {

        isdetached3 = killfuzzy_.isdetached;
           
        if (isdetached3==true)
            {
            isdetached2 = true;
            }
        
    }


}
