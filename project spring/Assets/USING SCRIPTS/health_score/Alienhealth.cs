using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alienhealth : MonoBehaviour


{
    public int alienHealth_;
    public int alienMaxHealth_;
    int Timer = 0;
    public GameObject bear;


    public void Awake()
    {
        bear = this.gameObject;
        Timer = 0;
        alienMaxHealth_ = 6;
        alienHealth_ = alienMaxHealth_;
    }


    public void Update()
    {
        if (alienHealth_ <= 0)
        {
          //  Destroy(bear);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Timer = 1;
            if (Timer == 1)
            {

                if (other.tag == "bullet")
                {
                    alienHealth_ -= 1;
                }
             


                Timer = 0;
            }

            if (alienHealth_ <= 0)
            {
                alienHealth_ = 0;
            }
        }

    }

}

