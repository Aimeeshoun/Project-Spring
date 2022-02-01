using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxTag : MonoBehaviour



{
    public GameObject other_gamobj;
    public UnityEvent onmouseDown_;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        OnMouseUp();
    }

    //  public void OnMouseDown()
    //  {
    // Destroy the gameObject after clicking on it
    //    onmouseDown_.Invoke();
    // }

    private void OnMouseUp()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        other_gamobj = other.gameObject;

        if(other_gamobj.tag == "boxes")
        {
            onmouseDown_.Invoke();
        }

    }

}

