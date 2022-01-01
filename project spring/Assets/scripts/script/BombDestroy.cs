using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BombDestroy : MonoBehaviour
{

    
  //  public BringScoreZero bringScoreZero;



    private void Start()
    {
      //  bringScoreZero = bringScoreZero.GetComponent<BringScoreZero>();
      
    }

    private void OnTriggerEnter(Collider other)
    {


       // bringScoreZero.MakeScoreZero();
        other.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
       
        //end scene 


    }
}
