using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Collider))]
public class Boundaries : MonoBehaviour
{



    public void Start()
    {


    }
    public void Update()
    {

    }



    public UnityEvent triggerEnterEvent, triggerExitEvent;
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Target")
        {
            triggerEnterEvent.Invoke();
        }


    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Target")
        {

            triggerExitEvent.Invoke();


        }

    }
}
