using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSOData : MonoBehaviour

{
    public IntData data;

    private IntData newData;
    // Start is called before the first frame update
    void Start()
    {
        newData = Instantiate(data);
    }
}
