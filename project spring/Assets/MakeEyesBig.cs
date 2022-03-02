using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEyesBig : MonoBehaviour
{

    public GameObject[] eyes;
    public GameObject eye;

    public GameObject bear;
    public KillEnemy thebool;
    public bool _ishit_;
    public Transform transform_1;
    public Transform transform_2;
    public Transform transform_3;
    public Transform transform_4;
    public Vector3 vec1_;
    public Vector3 vec2_;
    public Vector3 vec3_;
    public Vector3 vec4_;
    public GameObject gameobject_1;
    public GameObject gameobject_2;
    public GameObject gameobject_3;
    public GameObject gameobject_4;
    public Component[] eyeballs;
    public GameObject gameobject_5;
    public GameObject gameobject_6;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        bear = this.gameObject;
      
            thebool = bear.GetComponent<KillEnemy>();
            _ishit_ = thebool.ishit;

            gameobject_5 = bear.transform.GetChild(0).gameObject;

            gameobject_6 = gameobject_5.transform.GetChild(7).gameObject;

            gameobject_1 = gameobject_6.transform.GetChild(0).gameObject;
            gameobject_2 = gameobject_6.transform.GetChild(1).gameObject;
            gameobject_3 = gameobject_6.transform.GetChild(2).gameObject;
            gameobject_4 = gameobject_6.transform.GetChild(3).gameObject;
      
         

            transform_1 = gameobject_1.transform;
            vec1_ = transform_1.localScale;
            transform_2 = gameobject_2.transform;
            vec2_ = transform_2.localScale;
            transform_3 = gameobject_3.transform;
            vec3_ = transform_3.localScale;
            transform_4 = gameobject_4.transform;
            vec4_ = transform_4.localScale;

            if (_ishit_)
            {
       
                vec1_ = new Vector3(10f, 10f, 10f);

                vec2_ = new Vector3(10f, 10f, 10f);

                vec3_ = new Vector3(10f, 10f, 10f);

                vec4_ = new Vector3(10f, 10f, 10f);

            }


    }
}
