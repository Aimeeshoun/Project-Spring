using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipItKills : MonoBehaviour
{
    public GameObject skipit_;
    public GameObject fuzzy_;

    public GameObject dizzy_;
    public GameObject dizzy_2;

    public bool isCreated;

    // Start is called before the first frame update
    public  void Start()
    {
        dizzy_ = GameObject.FindGameObjectWithTag("par spiral");
    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        fuzzy_ = other.gameObject;


        if (fuzzy_.tag == ("Fuzzy"))
        {
            if (!isCreated)
            {
                dizzy_2 = Instantiate(dizzy_, fuzzy_.transform.position, fuzzy_.transform.rotation) as GameObject;
                Destroy(fuzzy_, .2f);
                Destroy(dizzy_2, .3f);
            }
         
          
        }
        
    }
    
}
