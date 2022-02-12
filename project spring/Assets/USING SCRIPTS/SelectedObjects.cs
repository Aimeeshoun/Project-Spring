using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{
    public GameObject[] myWeaponList2;
    public GameObject currentWeapon;
    private int index;
    public GameObject target;
    public IntData aliensDead;
    public int valueOfDead = 30;
    public killfuzzy grabIntData_;
    public GameObject alienAlive_;

    public void Update()
    {
        alienAlive_ = GameObject.FindGameObjectWithTag("Fuzzy");
        grabIntData_ = alienAlive_.GetComponent<killfuzzy>();
        aliensDead = grabIntData_.alienScore;
    }

    public void SelectedObject()
    {
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];
        currentWeapon = Instantiate(currentWeapon, target.transform.position, target.transform.rotation) as GameObject;
        currentWeapon.transform.parent = gameObject.transform;
    }

}





