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
    public Vector3 newSize;
 //   public int x;
 //   public int y;
  //  public int z;
    // Start is called before the first frame update
    void Start()
    {

     //   x = 10;
      //  y = 10;
     //   z = 10;
       
        newSize = new Vector3(50,50,50);



    }


    void Awake()
    {
        bear = this.gameObject;
        thebool = bear.GetComponent<KillEnemy>();
        gameobject_5 = bear.transform.GetChild(0).gameObject;

        gameobject_6 = gameobject_5.transform.GetChild(7).gameObject;

        gameobject_1 = gameobject_6.transform.GetChild(0).gameObject;
     //   gameobject_2 = gameobject_6.transform.GetChild(1).gameObject;
        gameobject_3 = gameobject_6.transform.GetChild(2).gameObject;
     //   gameobject_4 = gameobject_6.transform.GetChild(3).gameObject;

    }
    // Update is called once per frame
    void Update()
    {
        
   
            _ishit_ = thebool.ishit;

      

            if (_ishit_)
            {

                gameobject_1.gameObject.transform.localScale += new Vector3(.02f, .02f, .02f);
            //  gameobject_1.gameObject.transform.localScale += new Vector3(1f, 1f, 1f);

         //   gameobject_2.gameObject.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);

            gameobject_3.gameObject.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
          //  gameobject_3.gameObject.transform.localScale += new Vector3(1f, 1f, 1f);
          


        }


    }
}
