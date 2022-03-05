using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAiNow : MonoBehaviour
{

    public ClickonRods clickonRods_;
    public GameObject[] rods;
  
    public bool isClicked;
    public bool isclicked2;
    public bool isclicked3;

    public int Timer = 0;
    
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        rods = GameObject.FindGameObjectsWithTag("rod");

        foreach ( GameObject rod in rods)
        {
            
            
           
       
                clickonRods_ = rod.GetComponent<ClickonRods>();
                isClicked = clickonRods_.isclickedon;

            if (isClicked)
            {
                isclicked2 = true;
            }

        }

        if (isclicked2)
        {
            Timer++;
           if(Timer<= 500)
            {
                isclicked3 = true;
            }
            if (Timer >= 500)
            {
                isclicked3 = false;
            }

        }

    }
}
