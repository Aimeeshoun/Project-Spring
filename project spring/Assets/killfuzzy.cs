using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killfuzzy : MonoBehaviour
{
    public int Timer2 = 0;
    public GameObject bloodsplatter;

    private bool spawning;

    public GameObject currentBlood__;
    /// 
    public float spawnRate;

    public GameObject target;

    public GameObject this_gameObject;
    // public GameObject this_gameObject;

    public IntData alienScore;
    public int valueOfDead = 30;
    public Text text;
    public string scoreee;
    public GameObject Textbar_;
    public IntData score;
    public Image scorebar;
    public GameObject scorebar_;
    public int Timer = 0;

    public GameObject healthobj_;
    public Healthclamp2 healthtoNextLevel;
    public GameObject Alien_;


    // public Transform position_;
    // public Vector3 _position;
    public GameObject particle;
    public ParticleSystem particle_;

    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;

    public Alienhealth alienhealth;
    public int currentAlienHealth;

    public GameObject grabAlienhealth;

    public SelectedObjects selectedObjects;
    public GameObject weaponSpawner;
    public particlesystem particleSystem_obj;

    //    public GameObject[] Aliens_;

    // Start is called before the first frame update
    public void Start()
    {
        weaponSpawner = GameObject.FindGameObjectWithTag("weaponspawner");
        selectedObjects = weaponSpawner.GetComponent<SelectedObjects>();



        //   scorebar_ = GameObject.FindGameObjectWithTag("score bar 2");
        Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        scorebar = scorebar_.GetComponent<Image>();


        text = Textbar_.GetComponent<Text>();





    }


    public void Awake()
    {
        this_gameObject = this.gameObject;

        Timer = 0;
        Timer2 = 0;
    }
    // Update is called once per frame
    public void Update()
    {


        currentAlienHealth = alienhealth.alienHealth_;




        healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoNextLevel = healthobj_.GetComponent<Healthclamp2>();
        //   _postion = position_.position;
        //   _rotation = position_.rotation;



        text.text = alienScore.value.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {
        this_object = this_gameObject.transform;
        particle_ = particle_.GetComponent<ParticleSystem>();
        this_obj_ = this_object.position;
        other_obj_rotation = this_object.rotation;
        other_gameObject_ = other.gameObject;
        alienhealth = other_gameObject_.GetComponent<Alienhealth>();
        particleSystem_obj = other_gameObject_.GetComponent<particlesystem>();

        if (other_gameObject_.tag == "Fuzzy")

            if (currentAlienHealth <= 0)
            {
                Timer = 1;



                if (Timer == 1)
                {


                  

                    healthtoNextLevel.AddTotHealth2();
              //    particleSystem_obj.EmitParticles();
                    Destroy(other_gameObject_);
                    alienScore.value += 1;
                    Timer = 2;

            
                }




            }


        if (Timer == 2)
        {
            particle_.transform.position = this_obj_;
            particle_.transform.rotation = other_obj_rotation;
            BloodSplasts();
            Timer = 0;
        }

        //  BloodSplasts();
        //    Destroy(other_gameObject);
        //   BloodSplasts();

    }




    public void BloodSplasts()
    {



        currentBlood__ = Instantiate(currentBlood__, this_obj_, other_obj_rotation);
        currentBlood__.transform.parent = gameObject.transform;
      particle_.Emit(100);
        Destroy(currentBlood__, 2);
    //particle_.Emit(100);
        Destroy(this.gameObject, 2f);

        selectedObjects.SelectedObject();

    }

    //  public void DestroyBomb()
    //   {
    //      Destroy(this.gameObject,3f);
    //  }

}