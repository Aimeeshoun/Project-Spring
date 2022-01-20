using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowHealth : MonoBehaviour
{

    public int cowHealth_;
    public int cowMaxHealth_;

    //  public IntData cowMaxHealth_;

    //**** MAKE INTO INTDATA FOR MUILTI LEVELS  

    int Timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
       

    }
    public void Awake()
    {
       
        cowHealth_ = cowMaxHealth_;
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Fuzzy")
        {
            Timer++;
            if (Timer <= 1)
            {


                cowHealth_ -= 1;


                Timer = 0;
            }

            if(cowHealth_<= 0)
            {
                cowHealth_ = 0;
            }
        }
   
        }

    }

