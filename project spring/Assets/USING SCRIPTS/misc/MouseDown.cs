using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MouseDown : MonoBehaviour


{
    public UnityEvent onmouseDown_;

    void Update()
    {
        OnMouseUp();
    }

    private void OnMouseUp()
    {
        onmouseDown_.Invoke();
    }

}
