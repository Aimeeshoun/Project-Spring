using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticleSystem : MonoBehaviour
{

    public GameObject[] particlessystems_group;
    public GameObject particlessystems_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particlessystems_group = GameObject.FindGameObjectsWithTag("particlesystem");
      


    }



    public void DestroyParticles()
    {
        foreach (GameObject particlessystems_ in particlessystems_group)
        {
     //     Destroy(particlessystems_, 9f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fuzzy")
        {
      ///   DestroyParticles();
        }
    }
}
