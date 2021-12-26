using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingAnimation : MonoBehaviour
{


    public GameObject ui_Ring;
    private int index;
    public GameObject target;



    public GameObject otherGameObject;

    public SpawnRandomPoints _spawnRandomPoints;
    public BoxCollider _otherBoxcol;
    public CharacterSpawnRandom _characterSpawnRandom;
    public Animation anim;


    public void Awake()

    {
        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");


        ui_Ring = Instantiate(ui_Ring, target.transform.position, target.transform.rotation) as GameObject;
        ui_Ring.transform.parent = gameObject.transform;

        anim = gameObject.GetComponent<Animation>();
        

        _spawnRandomPoints = otherGameObject.GetComponent<SpawnRandomPoints>();
        _characterSpawnRandom = otherGameObject.GetComponent<CharacterSpawnRandom>();
        AnimateRing();
        


    }






    public void AnimateRing()
    {

        anim.Play("ring animation");


    }



}




