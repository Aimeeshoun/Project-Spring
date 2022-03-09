using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFire : MonoBehaviour
{

    public GameObject candlebear;
    public GameObject other_candlebear;
    public GameObject firestarter;
    public GameObject firestarter2;

    public Transform fuzzy_trans;
    public Vector3 fuzzy_Vec;
    public Quaternion fuzzy_Rot;

    public bool isOnFire;
    public bool isdead;
    public bool isCreated = false;

    public GameObject thefire;






    // Start is called before the first frame update
    void Start()
    {
        thefire = GameObject.FindGameObjectWithTag("candle");
    }

    // Update is called once per frame


    public void Update()
    {
        fuzzy_trans = other_candlebear.transform;
        fuzzy_Vec = fuzzy_trans.position;
        fuzzy_Rot = fuzzy_trans.rotation;
       
       if(isOnFire)
        {
            if (!isCreated)
            {
                firestarter2 = Instantiate(thefire, fuzzy_Vec, fuzzy_Rot) as GameObject;
                isCreated = true;
                isOnFire = false;
            }
        }
    
    }


    public void OnTriggerEnter(Collider other)
    {
        other_candlebear = other.gameObject;

        isOnFire = true;
    }

}