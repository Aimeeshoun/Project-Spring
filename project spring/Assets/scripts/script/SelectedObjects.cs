using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{

    public GameObject[] myWeaponList2;

    public GameObject currentWeapon;
    public GameObject newWeapon;
    private int index;
    private int index2;
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
    public void NewWeapon()
    {
        index2 = Random.Range(0, myWeaponList2.Length);
        newWeapon = myWeaponList2[index2];
        newWeapon = Instantiate(newWeapon, target.transform.position, target.transform.rotation) as GameObject;
        newWeapon.transform.parent = gameObject.transform;
        currentWeapon == newWeapon;
    }



}



