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

        // Update is called once per frame
    }
    
    public void Update()
    {
        KillFuzzes = GameObject.FindGameObjectsWithTag("Fuzzy");
        if (KillFuzzes.Length > 0)
        {
            foreach (GameObject killFuzz in KillFuzzes)
            {
               killfuzzy_ = killFuzz.GetComponent<killfuzzy>();

               isdetached3 = killfuzzy_.isdetached;


                if (isdetached3 == true)
                {
                    isdetached2 = true;
                }
            }
            isdetached2 = false;
            isdetached3 = false;

        }
       


    }


}
