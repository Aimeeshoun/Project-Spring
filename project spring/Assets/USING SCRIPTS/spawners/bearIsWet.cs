using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearIsWet : MonoBehaviour
{
    public GameObject other_bear;
    public GameObject other_bear2;

    public GameObject Water_par;
    public GameObject Water_par2;

    public bool iswet;

    // Start is called before the first frame update
    public void Start()
    {
        Water_par = GameObject.FindGameObjectWithTag("water drops");
    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        other_bear = other.gameObject;

        if (other_bear.tag == ("Fuzzy"))
            {

            other_bear2 = other_bear;


            if (!iswet)
            {
                Water_par2 = Instantiate(Water_par, other_bear2.transform.position, other_bear2.transform.rotation) as GameObject;
                Water_par2.transform.SetParent(other_bear2.transform);
                iswet = true;
            }
         

            Destroy(Water_par2, 5f);
        }
    }
}
