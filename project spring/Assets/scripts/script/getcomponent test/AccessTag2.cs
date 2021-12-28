using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTag2 : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        objects[2].GetComponent<Renderer>().material.color = colors[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
