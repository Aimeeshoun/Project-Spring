using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour
{

    public Transform lookObj;
    public void Update()
    {
        // Transform transform1;
        //(transform1 = transform).LookAt(obj.value);
        //var transformRotation = transform1.eulerAngles;
        //transformRotation.x = 0;
        // transformRotation.y -= 90;
        // transform.rotation = Quaternion.Euler(transformRotation);

        transform.LookAt(lookObj);
        var transformRotation = transform.eulerAngles;
        transformRotation.x = 0;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}

