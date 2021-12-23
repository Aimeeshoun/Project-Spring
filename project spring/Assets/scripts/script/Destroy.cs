using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    public GameObject gamobj;

    public GameObject gamobj2;

    public ID id;
    public ID id2;


    public GameObject[] myList;


    void OnTriggerEnter(Collider other)
    {

        id = gamobj.GetComponent<ID>();
        id2 = gamobj2.GetComponent<ID>();
        SelectedObjects currentSelectedWeapon = GetComponent<SelectedObjects>();
        //  currentWeap = currentSelectedWeapon.currentSelectedWeapon;

        foreach (var i in myList)
        {
            if (i == true)
            {


                //     if (currentWeap ==  )
                {
                    Destroy(this.gameObject);
                    Destroy(other.gameObject);
                }
            }
        }



    }
}