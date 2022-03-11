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
    public bool isclicked2;
    public bool fire;
    public bool alreadyfired;


    public Transform trans;
    public Vector3 Pos;
    public Quaternion Rot;

    public bool clickedonce;
    public bool clickedon;

    public bool isclickedonagain;

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

        if (!clickedon)
        {
            if (clickedonce)
            {

                if (isclicked)
                {
                    Fire();
                }
                clickedon = true;
            }
           
        }

        if (clickedonce)
        {
            if (!isclickedonagain)
            {

                isclickedonagain = true;
            }

        }








    }












    public void Fire()
    {

        if (isclicked)
        {

            if (!fire)
            {
                if (clickedonce == true)
                {

                    newbullet = Instantiate(bullet, Pos, Rot) as GameObject;
                    Destroy(newbullet, 3f);
                    fire = true;
                }

            }






        }
    }
   

    private void OnMouseDown()
    {

        if (!clickedon)
        {
            
            isclicked = true;
        }

   



    }

    private void OnMouseUp()
    {
       if(!isclicked2)
      
        {
            

            clickedonce = true;
            isclicked2 = true;


         

        }


    }


}




