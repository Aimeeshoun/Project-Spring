using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killfuzzy : MonoBehaviour
{
    public int Timer2 = 0;
    public GameObject currentBlood__;
    public GameObject this_gameObject;
    public IntData alienScore;
   public Text text;
   public GameObject Textbar_;
    public Image scorebar;
    public GameObject scorebar_;
    public int Timer = 0;
    public GameObject healthobj_;
    public Healthclamp2 healthtoNextLevel;
    public GameObject particle;
    public ParticleSystem particle_;
    public Transform this_object;
    public Vector3 this_obj_;
    public Quaternion other_obj_rotation;
    public GameObject other_gameObject_;
    public Alienhealth alienhealth;
    public int currentAlienHealth;
    public SelectedObjects selectedObjects;
    public GameObject weaponSpawner;
    public particlesystem particleSystem_obj;
    public GameObject[] particlessystems_group;
    public GameObject particlessystems_;
    public bool isdetached;

    public void Start()
    {
        weaponSpawner = GameObject.FindGameObjectWithTag("weaponspawner");
     //   scorebar = scorebar_.GetComponent<Image>();
        if (!weaponSpawner == null)
        {
            selectedObjects = weaponSpawner.GetComponent<SelectedObjects>();
            //     Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        
            //  text = Textbar_.GetComponent<Text>();
        }
   
    }

    public void Awake()
    {
        this_gameObject = this.gameObject;

        Timer = 0;
        Timer2 = 0;
    }

    public void Update()
    {
       
     
        healthobj_ = GameObject.FindGameObjectWithTag("health obj");
    //    healthtoNextLevel = healthobj_.GetComponent<Healthclamp2>();
   //     text.text = alienScore.value.ToString();
        particlessystems_group = GameObject.FindGameObjectsWithTag("particlesystem");


    }
    public void OnTriggerEnter(Collider other)
    {
       if(!other.gameObject == null) {




            this_object = this_gameObject.transform;
            particle_ = particle_.GetComponent<ParticleSystem>();
            this_obj_ = this_object.position;
            other_obj_rotation = this.gameObject.transform.rotation;
            other_gameObject_ = other.gameObject;



            if (other_gameObject_.tag == "Fuzzy")
                currentAlienHealth = alienhealth.alienHealth_;
            alienhealth = other_gameObject_.GetComponent<Alienhealth>();
            particleSystem_obj = other_gameObject_.GetComponent<particlesystem>();
            if (currentAlienHealth <= 0)
            {
                Timer = 1;

                if (Timer == 1)
                {

                    healthtoNextLevel.AddTotHealth2();
                    particleSystem_obj.EmitParticles();
                    Destroy(other_gameObject_);
                    alienScore.value += 1;
                    Timer = 2;

                }

            }

            if (Timer == 2)
            {
                particle_ = Instantiate(particle_, this_obj_, other_obj_rotation);
                particle_.transform.position = this_obj_;
                particle_.transform.rotation = other_obj_rotation;
                BloodSplasts();
                Timer = 0;
            }

        }





    }
        
   

    public void BloodSplasts()
    {

        currentBlood__ = Instantiate(currentBlood__, this_obj_, other_obj_rotation);
        currentBlood__.transform.parent = gameObject.transform;
        particle.transform.DetachChildren();
        isdetached = true;
        particle_.Emit(100);
        Destroy(currentBlood__, 9);
        DestroyParticles();
      if(this_gameObject.tag == "bullet")
        {
            Destroy(this.gameObject, 9f);
        }
  
    }

    public void DestroyParticles()
    {
        foreach (GameObject particlessystems_ in particlessystems_group)
        {
            Destroy(particlessystems_, 1f);
        }
    }
}