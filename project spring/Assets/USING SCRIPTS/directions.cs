using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directions : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;
    private Vector3 thePosition;

    private Vector3 currentRotation;

    public GameObject target;



    public bool left1;
    public bool right1;
    public bool up;
    public bool down;

    public void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();
     
        m_Speed = 30.0f;

       
    }

    public void Update()
    {
   

   //     if (right1 || left1)
   //     {
     //       m_Rigidbody.rotation = Quaternion.Euler(0, 0.0f, 0);

     //   }
     

   // if (up || down)
   //     {

   //         m_Rigidbody.rotation = Quaternion.Euler(0, 90.0f, 0);
   //     }



    }

    public void right()
    {
        //  m_Rigidbody.velocity = -transform.up * m_Speed;
        // transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        right1 = true;
    
        //  m_Rigidbody.rotation = Quaternion.Euler(0, 0.0f, 0);
        m_Rigidbody.velocity = transform.right * m_Speed;
  
    }

    public void left()
    {
        left1 = true;

        //   m_Rigidbody.rotation = Quaternion.Euler(0, 90f, 0);
        //  m_Rigidbody.velocity = -transform.right * m_Speed;
        m_Rigidbody.velocity = -transform.right * m_Speed;

    }




    public void MoveUp()
    {

        up = true;
        //   m_Rigidbody.velocity = transform.up * m_Speed;
        //  transform.Rotate(new Vector3(0,-1, 0) * Time.deltaTime * m_Speed, Space.World);

        m_Rigidbody.rotation = Quaternion.Euler(0, 90.0f, 0);
    //    m_Rigidbody.velocity = transform.right * m_Speed;
       
    }

    public void MoveDown()
    {

        down= true;
        //   m_Rigidbody.velocity = transform.up * m_Speed;
        //  transform.Rotate(new Vector3(0,-1, 0) * Time.deltaTime * m_Speed, Space.World);
        m_Rigidbody.rotation = Quaternion.Euler(0, 0f, 0);

     //  m_Rigidbody.velocity = -transform.right * m_Speed;
  
    }



}
