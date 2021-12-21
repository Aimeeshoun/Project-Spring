using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateObj : MonoBehaviour
{
    public GameObject gameObject;
    
    public void Awake()
    {
        Instanciate(gameObject)
    }
}
