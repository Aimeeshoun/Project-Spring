using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour


{
    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 30.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move the Rigidbody to the right constantly at speed you define (the red arrow axis in Scene view)
            m_Rigidbody.velocity = transform.right * m_Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move the Rigidbody to the left constantly at the speed you define (the red arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.right * m_Speed;
        }

    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
          
    //        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed, Space.World);
    //    }

       // if (Input.GetKey(KeyCode.DownArrow))
      //  {
         
      //      transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * m_Speed, Space.World);
     //  }
    }
}
