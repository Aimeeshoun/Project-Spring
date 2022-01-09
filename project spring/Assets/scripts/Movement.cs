using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour


{



    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Speed = 30.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow  ))
        {

            m_Rigidbody.velocity = transform.right * m_Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow  ))
        {

            m_Rigidbody.velocity = -transform.right * m_Speed;
        }

        if (Input.GetKey(KeyCode.UpArrow  ))
        {

            m_Rigidbody.velocity = transform.up * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
          {

                 
        m_Rigidbody.velocity = -transform.up * m_Speed;
        }
    }
}
