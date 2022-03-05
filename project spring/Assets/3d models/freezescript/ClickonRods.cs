using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickonRods : MonoBehaviour
{

    public GameObject thisrod;
    public bool isclickedon;
    public bool click;
    
    // Start is called before the first frame update
    public void Start()
    {
        thisrod = this.gameObject;

        
    }

    public void Awake()
    {
        isclickedon = false;
        click = false;
    }
    // Update is called once per frame
    public void Update ()
    {
        if (click)
        {
            isclickedon = true;
        }
    }

    public void OnMouseDown()
    {
        click = true;
    }

}
