using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFuzzy : MonoBehaviour
{

    public GameObject fuzzies;
    public GameObject fuzzy;
    public SpawnRandomPoints fuzziess;
    public GameObject spawn;


    void Update()
    {
        spawn = GameObject.FindGameObjectWithTag("fuzzyspawn");
     
            fuzziess= spawn.GetComponent<SpawnRandomPoints>();
       
        fuzzies = fuzziess.currentChar;
       
            DestroyFuzziess();
 

    }

    public void DestroyFuzziess()
    
    {
        
                Destroy(fuzzies, 50f);
        
    }


}

