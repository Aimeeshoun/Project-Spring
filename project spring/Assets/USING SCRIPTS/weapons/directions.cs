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

    public void right()
    {
        right1 = true;
        m_Rigidbody.velocity = transform.right * m_Speed;
  
    }

    public void left()
    {
        left1 = true;
        m_Rigidbody.velocity = -transform.right * m_Speed;

    }

    public void MoveUp()
    {
        up = true;
        m_Rigidbody.rotation = Quaternion.Euler(0, 90.0f, 0);
    }

    public void MoveDown()
    {
        down= true;
        m_Rigidbody.rotation = Quaternion.Euler(0, 0f, 0);
    }

}
