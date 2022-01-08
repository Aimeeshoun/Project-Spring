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

    }


}

