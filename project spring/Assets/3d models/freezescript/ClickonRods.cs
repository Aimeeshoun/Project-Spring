using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickonRods : MonoBehaviour
{

    public GameObject thisrod;
    public bool isclickedon;
    public bool click;

    public int Timer;
    
    // Start is called before the first frame update
  

    public void Awake()
    {
        thisrod = this.gameObject;
        isclickedon = false;
        click = false;
    }
    // Update is called once per frame
    public void Update ()
    {
        if (click)
        {
            Timer = 1;
           if (Timer == 1)
            {
                isclickedon = true;
                Timer = 0;
            }
            
            
            
        }
    }

    public void OnMouseDown()
    {
        StartCoroutine(Freeze2());
        Freeze2(); ;


    }



    IEnumerator Freeze2()
    {
        //Print the time of when the function is first called.
        click = true;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        click = false;

    }
}

