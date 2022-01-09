using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directions : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;
    private Vector3 thePosition;

    private Vector3 currentRotation;
    public void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody>();

        m_Speed = 30.0f;
    }

    public void Update()
    {
    }

    public void MoveForward()
    {
        //  m_Rigidbody.velocity = -transform.up * m_Speed;
        // transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);


        m_Rigidbody.rotation = Quaternion.Euler(0, 0.0f, 0);
        m_Rigidbody.velocity = -transform.right * m_Speed;
    }

    public void GoBack()
    {
        m_Rigidbody.rotation = Quaternion.Euler(0, 0f, 0);
        m_Rigidbody.velocity = transform.right * m_Speed;

    }




    public void MoveUp()
    {


        //   m_Rigidbody.velocity = transform.up * m_Speed;
        //  transform.Rotate(new Vector3(0,-1, 0) * Time.deltaTime * m_Speed, Space.World);
        m_Rigidbody.rotation =  Quaternion.Euler(0, 90.0f, 0);
        m_Rigidbody.velocity = transform.right * m_Speed;
    }

    public void MoveDown()
    {


        //   m_Rigidbody.velocity = transform.up * m_Speed;
        //  transform.Rotate(new Vector3(0,-1, 0) * Time.deltaTime * m_Speed, Space.World);
        m_Rigidbody.rotation = Quaternion.Euler(0, 90.0f, 0);
        m_Rigidbody.velocity = -transform.right * m_Speed;
    }



}
