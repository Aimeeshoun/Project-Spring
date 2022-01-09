using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movemnent1 : MonoBehaviour
{

    public float characterSpeed;
    public float normalSpeed;
    public float fastSpeed;
    public Rigidbody myRigid;
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        Vector3 theMovement = new Vector3(horizontalAxis, 0, verticalAxis) * characterSpeed * Time.deltaTime;
        myRigid.MovePosition(transform.position + theMovement);

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            characterSpeed = normalSpeed;

        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            characterSpeed = fastSpeed;
        }
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //rotate the sprite about the Z axis in the positive direction
        //    transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed, Space.World);
        // }

        //  if (Input.GetKey(KeyCode.DownArrow))
        // {
        //rotate the sprite about the Z axis in the negative direction
        //  transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * m_Speed, Space.World);
        //   }
    }


}

