using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(IntData))]
public class powerUpScript : MonoBehaviour
{
   public IntData data;

    void Awake()

    {
        data = GetComponent<IntData>();
    }



    public void UpdateImage()

    {
        data.value+= 1 ;
        
    }

}
