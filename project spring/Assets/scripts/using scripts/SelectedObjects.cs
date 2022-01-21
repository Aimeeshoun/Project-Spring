using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{

    public GameObject[] myWeaponList2;

    public GameObject currentWeapon;
    public SelectedObjects selectedObjects;
    public GameObject currentWeapon2;

    private int index;

    public GameObject target;




    public void Start()

    {
        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
       
        SelectedObject();

    //    selectedObjects = currentWeapon.GetComponent<SelectedObjects>();
        



    }

    public void Update()
    {
    //    currentWeapon2 = selectedObjects.currentWeapon;

        if(currentWeapon == null)
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



