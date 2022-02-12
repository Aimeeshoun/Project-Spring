using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
   private Rigidbody rbody;
   public float force = 38f;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force, 0, 0);
        rbody.AddRelativeForce(forceDirection);

    }



}

