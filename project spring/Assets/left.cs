using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class left : MonoBehaviour { 

     Rigidbody m_Rigidbody;
    float m_Speed;

       void Start()
    {
    //Fetch the Rigidbody component you attach from your GameObject
    m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 20.0f;
    }
void Update()
{

        OnMouseDown();

 
}


    public UnityEvent mouseDownEvent;
    private void OnMouseDown()
    {
        m_Rigidbody.velocity = -transform.right * m_Speed;
    }
}



