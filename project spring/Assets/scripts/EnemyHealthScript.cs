using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour


{
    private EnemyHealth eHealth;
    private void Start()
    {
        eHealth = ScriptableObject.CreateInstance<EnemyHealth>();
    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Weapon")
        {
            eHealth.value = -0.1f;

        }
       
    }
}

