using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alienhealth : MonoBehaviour


{
    public int alienHealth_;
    public int alienMaxHealth_;
    int Timer = 0;


    public void Awake()
    {
        Timer = 0;
        alienMaxHealth_ = 6;
        alienHealth_ = alienMaxHealth_;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet"|| other.tag == "firepit")
        {
            Timer = 1;
            if (Timer == 1)
            {

                if (other.tag == "bullet")
                {
                    alienHealth_ -= 1;
                }
                if (other.tag == "firepit")
                {
                    alienHealth_ -= 6;
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

