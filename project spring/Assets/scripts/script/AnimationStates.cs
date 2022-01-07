using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Animator))]
public class AnimationStates : MonoBehaviour

{
    private Animator anims;
    private void Start()
    {
        anims = GetComponent<Animator>();
        anims.SetTrigger("WALK");


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cow box")
        {
            anims.SetTrigger("EAT");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cow box")
        {
            anims.SetTrigger("WALK");
        }
    }
}
