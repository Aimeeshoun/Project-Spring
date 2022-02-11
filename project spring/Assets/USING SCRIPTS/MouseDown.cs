using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MouseDown : MonoBehaviour


{

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
        onmouseDown_.Invoke();
    }


}
