using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour
{
    public KillEnemy dead;
    public bool isdead_;
    public GameObject bear;
    public GameObject gameobject_1;
    public Transform transform_;

    // Start is called before the first frame update
    public void Start()
    {



    }
    public void Awake()
    {
        bear = this.gameObject;
        dead = bear.GetComponent<KillEnemy>();
        isdead_ = dead.isdead;

    }
    // Update is called once per frame
    public void Update()
    {
        gameobject_1 = bear.transform.GetChild(1).gameObject;
        isdead_ = dead.isdead;
        transform_ = gameobject_1.transform;

        if (isdead_)
        {


            transform_.parent = null;
            Destroy(gameobject_1, 7f);

        }
    }
}