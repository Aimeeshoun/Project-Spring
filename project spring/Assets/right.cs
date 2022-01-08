using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class right : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
    
        m_Rigidbody = GetComponent<Rigidbody>();
      
        m_Speed = 20.0f;
    }
    void Update()
    {

        OnMouseDown();


    }


    public UnityEvent mouseDownEvent;
    private void OnMouseDown()
    {
        m_Rigidbody.velocity = transform.right * m_Speed;
    }
}



