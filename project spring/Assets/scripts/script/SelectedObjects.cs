using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{

    public GameObject[] myWeaponList2;

    public GameObject currentWeapon;
    private int index;
    public GameObject target;





    public void Start()

    {
        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
       
        SelectedObject();





    }

    public void Update()
    {
        if (!currentWeapon)
        {
            SelectedObject();
        }
    }



    public void SelectedObject()
    {
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];
        currentWeapon = Instantiate(currentWeapon, target.transform.position, target.transform.rotation) as GameObject;
        currentWeapon.transform.parent = gameObject.transform;
    }

}



