using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{

    public GameObject[] myWeaponList2;

    private GameObject currentWeapon;
    private int index;
    public GameObject target;



 


    public void Start()

    {
       // selectRandomObjects();
        myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];
        currentWeapon = Instantiate(currentWeapon, target.transform.position, target.transform.rotation) as GameObject;
        currentWeapon.transform.parent = gameObject.transform;
   

    }

    
    
    // public void selectRandomObjects()

    // {
    // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
    //    index = Random.Range(0, myWeaponList2.Length);
    //    currentWeapon = myWeaponList2[index];
    //   currentWeapon = Instantiate(currentWeapon, target.transform.position, target.transform.rotation) as GameObject;
    //   currentWeapon.transform.parent = gameObject.transform;

}



