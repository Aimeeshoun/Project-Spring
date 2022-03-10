using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bullet2;
    public Transform bullet3;
    public GameObject gun;
    public GameObject[] guns;
    public GameObject newbullet;

    public bool isclicked;
    public bool fire;
    public bool alreadyfired;


    public Transform trans;
    public Vector3 Pos;
    public Quaternion Rot;

    public void Start()
    {

        bullet = GameObject.FindGameObjectWithTag("bullet2");
        
  

    }

    public void Awake()
    {
        bullet2 = this.gameObject;
    }


    public void Update()
    {
        bullet3 = bullet2.transform.GetChild(4);
        trans = bullet3.transform;
        Pos = trans.position;
        Rot = trans.rotation;


        Fire();



    }

    public void Fire()
    {

        if (!fire)
        {
            if (isclicked)
            {
                newbullet = Instantiate(bullet, Pos, Rot) as GameObject;
                Destroy(newbullet, 3f);
                fire = true;
            }
           
        }

        
  

    }

    private void OnMouseDown()
    {
      
        
        isclicked = true;



    }


}




