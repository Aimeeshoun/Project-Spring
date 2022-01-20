using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killfuzzy : MonoBehaviour
{

    public GameObject bloodsplatter;

    private bool spawning;

    public GameObject currentBlood__;
    /// 
    public float spawnRate;

    public GameObject target;

    public GameObject other_gameObject;
    public GameObject this_gameObject;

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
//    public GameObject[] Aliens_;

    // Start is called before the first frame update
    public void Start()
    {
     //   scorebar_ = GameObject.FindGameObjectWithTag("score bar 2");
        Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        scorebar = scorebar_.GetComponent<Image>();
   
      
        text = Textbar_.GetComponent<Text>();

        Alien_ = GameObject.FindGameObjectWithTag("Fuzzy");

    }

    // Update is called once per frame
    public void Update()
    {
        healthobj_ = healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoNextLevel = healthobj_.GetComponent<Healthclamp2>();
     //   _postion = position_.position;
     //   _rotation = position_.rotation;


        text.text = alienScore.value.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {

        other_gameObject = other.gameObject;
      
            if (other_gameObject.tag == "Fuzzy")
            {

                Timer = +1;

                if (Timer <= 1)
                {


                    alienScore.value += 1;
                    healthtoNextLevel.AddTotHealth2();

                    BloodSplasts();

                    Timer = 0;
                }



              //  BloodSplasts();
            //    Destroy(other_gameObject);
             //   BloodSplasts();

            }
     
        
       
        
    }



    public void  BloodSplasts()
    {

        Destroy(other_gameObject);
        currentBlood__ = Instantiate(currentBlood__, other_gameObject.transform.position, other_gameObject.gameObject.transform.rotation) as GameObject;
        currentBlood__.transform.parent = gameObject.transform;
        Destroy(currentBlood__, 3f);
   



    }

    public void DestroyBomb()
    {
        Destroy(this.gameObject,3f);
    }

}