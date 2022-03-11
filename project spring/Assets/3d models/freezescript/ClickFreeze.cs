using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFreeze : MonoBehaviour
{
    public GameObject[] objects_;
    public GameObject object_;
    public GameObject object2_;


    public KillEnemy killenemy_;
    public Transform[] transforms_;
    public Transform transform_;

    public Vector3[] vecs_;
    public Vector3 vec_;

    public Quaternion Quaternion_;
    public Quaternion[] Quaternions;
    public GameObject lighting_;
    public GameObject lighting2;
    public GameObject intcrip;
    public bool needinfo;
    public bool ishit;
    
    public bool ishit2;

    public bool istrueee;
    public ClickonRods click_on_rods;
    public int Timer;
    public int Timer2;

    public bool clickrod;
    public bool isCrisp;
    public instanciateCrisp instanciateCrisp_;
    public aiSpeedchange ai_speed;
    public bool isburn;

    public spraygun Spraygun_;
    public GameObject bear_obj;
    public GameObject[] this_gameobj;

    public bool iswet;
    public bool iswet2;
    // Start is called before the first frame update
   public void Start()
    {
      
    }

    public void Awake()
    {
        this_gameobj = GameObject.FindGameObjectsWithTag("spraygun");
      
    }

    // Update is called once per frame
    public void Update()
    {
        this_gameobj = GameObject.FindGameObjectsWithTag("spraygun");
        foreach(GameObject gun in this_gameobj)
        {
            Spraygun_ = gun.GetComponent<spraygun>();
            iswet = Spraygun_.water;
            if (iswet)
            {
                iswet2 = true;

            }
        }


            objects_ = GameObject.FindGameObjectsWithTag("Fuzzy");
            lighting_ = GameObject.FindGameObjectWithTag("lightingpar");
            intcrip = GameObject.FindGameObjectWithTag("instanciatecrips");


            click_on_rods = this.gameObject.GetComponent<ClickonRods>();
            clickrod = click_on_rods.isclickedon;

            instanciateCrisp_ = intcrip.GetComponent<instanciateCrisp>();

            foreach (GameObject object_ in objects_)
            {
                bear_obj = object_;

                killenemy_ = bear_obj.GetComponent<KillEnemy>();

                ai_speed = bear_obj.GetComponent<aiSpeedchange>();


                transform_ = killenemy_.this_object2;


                vec_ = killenemy_.this_obj_2;

                Quaternion_ = killenemy_.other_obj_rotation2;
                if (isburn)
                {

                if (iswet2)
                {
                    ai_speed.Freeze4();
                }
                }

                if (clickrod)
                {

                    Timer = 1;

                    if (Timer == 1)
                    {
                        isCrisp = true;

                        lighting2 = Instantiate(lighting_, vec_, Quaternion_) as GameObject;

                        Timer2 = 1;

                        if (Timer2 == 1)
                        {
                            StartCoroutine(Freeze3());
                            Freeze3();
                            Timer2 = 0;
                        }
                        Timer2 = 0;
                        Destroy(lighting2, .3f);



                        Timer = 0;
                    }

                    Timer = 0;
                }



        }

            
 

      

       
    }
    IEnumerator Freeze3()
    {
        //Print the time of when the function is first called.
        isburn=true;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(.2f);

        //After we have waited 5 seconds print the time again.
        isburn=false;

    }


}