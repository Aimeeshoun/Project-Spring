using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spraygun : MonoBehaviour
{


    public GameObject gun;
    public GameObject waterpar;
    public GameObject waterpar2;
    public GameObject waterpartarget;
    public Transform bullet3;
    public GameObject gun2;
    public GameObject[] guns;
    public GameObject newbullet;

    public bool isclicked;
    public bool water;
    public bool alreadywater;


    public Transform trans;
    public Vector3 Pos;
    public Quaternion Rot;

    public GameObject gun1;
    public Transform gun4;
    public GameObject puddle;
    public GameObject puddletarget;
    public Vector3 puddletargetvec;
    public Quaternion puddletargetqua;
    public GameObject puddle2;

    public bool madepuddle;
    public bool iswet;
    public bool iswet2;
    public bool ispar;
    public bool needswater;
    public bool puddlegone;
    public void Start()
    {

        waterpar = GameObject.FindGameObjectWithTag("water spray");
        puddle = GameObject.FindGameObjectWithTag("puddle on ground");
        puddletarget = GameObject.FindGameObjectWithTag("waterpuddletarget");
        puddletargetvec = puddletarget.transform.position;
        puddletargetqua = puddletarget.transform.rotation;
     
      

    }

    public void Awake()
    {

        gun1 = this.gameObject;
        gun4 = gun1.transform.GetChild(1);
    }



public void Update()
    {
    
        if (iswet)
        {
            needswater = true;
        }

        if (isclicked)
        {

            if (!ispar)
            {
                waterpar2 = Instantiate(waterpar, gun4.transform.position, gun4.transform.rotation) as GameObject;
                waterpar2.transform.SetParent(gun4.transform);
             
                ispar = true;
            }

            iswet = true;

        }

        if (iswet)
        {

            if (!iswet2)
            {
                puddle2 = Instantiate(puddle, puddletargetvec, puddletargetqua) as GameObject;

                if (!puddlegone)
                {


                    Destroy(puddle2, 4f);


                    if(puddle2 == null)
                    {
                        puddlegone = true;

                    }
                  
                }
            }

            madepuddle = true;


        }
   
        if (puddlegone)
        {
            madepuddle = false;
        }
    }


    private void OnMouseDown()
    {


        isclicked = true;



    }

    private void OnMouseUp()
    {
        Destroy(waterpar2,6f);
        

        isclicked = false;


    }
}



