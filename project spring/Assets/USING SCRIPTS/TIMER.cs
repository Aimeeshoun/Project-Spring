using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TIMER : MonoBehaviour
{

    public int Time;
    public int newTimer=0;
    public int current_time;
   
    


    // Update is called once per frame
    public void Update()
    {

    //    newTimer = 1;
        
        IncrementScore();
        current_time = Time;
    }
    
    
    
    public void IncrementScore()
    {
        newTimer = 1;
        if(newTimer == 1)
        {
            Time++;
            newTimer = 0;
        }
      
  
    }


}




