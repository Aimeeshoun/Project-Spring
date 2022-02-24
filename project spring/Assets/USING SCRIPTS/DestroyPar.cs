using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPar : MonoBehaviour
{
    public GameObject[] pars;
    public GameObject par;
    public killfuzzy killfuzzy_;
    public GameObject[] bullets;
    public GameObject bullet;
    public bool isDetach;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pars = GameObject.FindGameObjectsWithTag("particlesystem");
        bullets = GameObject.FindGameObjectsWithTag("bullet");
        foreach (GameObject bullet in bullets)
        {
            killfuzzy_ = bullet.GetComponent<killfuzzy>();
            isDetach = killfuzzy_.isdetached;
        }

        if (isDetach)
        {
            DestroyParticles();
            
            
        }
    }

    public void DestroyParticles()
    {
        foreach (GameObject par in pars)
        {

         
                Destroy(par, 1f);
            
        }
    }
}