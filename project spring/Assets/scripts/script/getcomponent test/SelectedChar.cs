using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedChar : MonoBehaviour
{

    public GameObject[] myCharacterList;

    public GameObject currentChar;
    private int index;
    public GameObject target;

    public GameObject[] currentSelectedChar;




    public void Start()

    {
        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        index = Random.Range(0, myCharacterList.Length);
        currentChar = myCharacterList[index];
        currentChar = Instantiate(currentChar, target.transform.position, target.transform.rotation) as GameObject;
        currentChar.transform.parent = gameObject.transform;
        currentChar = currentSelectedChar[index];




    }



}

