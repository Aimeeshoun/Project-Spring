using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    

    
    RingAnimation : MonoBehaviour
{

    public GameObject ui_Ring;
    private int index;
    public GameObject target;

    public GameObject otherGameObject;

    public SpawnRandomPoints _spawnRandomPoints;
    public BoxCollider _otherBoxcol;
    public CharacterSpawnRandom _characterSpawnRandom;
    public Animation anim;
    public GameObject thistag;
    public GameObject othertag;
   
    private GameObject Target_;

    /// <summary>
    /// /
    /// </summary>
 
    private void Start()
    {

        anim = gameObject.GetComponent<Animation>();
    }
    ////


    private void Update()
    {
        Target_ = this.gameObject;
        DestroyMakeRing();

    }

    public void Awake()

    {
        // selectRandomObjects();
        // myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
    }

    public void AnimateRing()
    {

        anim.Play("ring animation");

    }

    private void DestroyMakeRing()
    {
      
        if (!Target_)
        {
            ui_Ring = Instantiate(ui_Ring, Target_.transform.position, Target_.transform.rotation) as GameObject;
            ui_Ring.transform.parent = gameObject.transform;
           
        }
    }

}