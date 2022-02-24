using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detroydeadbears : MonoBehaviour
{
    public GameObject[] bears;
    public GameObject bear;
    public KillEnemy _killenemy;
    public int healthScore;
    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject blood;
    public GameObject blood_;
    public GameObject bear_;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blood = GameObject.FindGameObjectWithTag("blooood");
        bears = GameObject.FindGameObjectsWithTag("Fuzzy");
        bear = bear_  ;
       
        foreach (GameObject bear in bears)
        {
            bear_ = bear;

            _killenemy = bear_.GetComponent<KillEnemy>();
            healthScore = _killenemy.Enemyheath;
            this_object = _killenemy.this_object;
            other_obj_rotation = _killenemy.other_obj_rotation;
            this_obj_ = _killenemy.this_obj_;

            if (healthScore <= 0)
            {
                _killenemy.BloodSplasts();
                Destroy(bear_);

            }

            //   if(healthScore <= 0)
            //  {
            //  _killenemy.BloodSplasts();
            //     blood = Instantiate(blood, this_obj_, other_obj_rotation);
            //     blood_.transform.parent = gameObject.transform;
            //     }

        }
       
    }
}
