using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage2 : MonoBehaviour

{
    public int healthValue;
    public float Health = 100;
    private void OnTriggerEnter(Collider other)
    {
        Health -= 5;


    }

}

