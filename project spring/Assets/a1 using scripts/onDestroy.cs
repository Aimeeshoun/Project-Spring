using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onDestroy : MonoBehaviour

{
    public UnityEvent DestroyEvent;
    private void OnDestroy()

    {
        DestroyEvent.Invoke();
    }

}
