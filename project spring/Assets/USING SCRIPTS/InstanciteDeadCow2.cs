using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciteDeadCow2 : MonoBehaviour
{

    public GameObject deadcow;
    public GameObject deadcow2;

    public GameObject deadcow3;
    public GameObject this_gamObj;
    public GameObject this_gamObj2;
    private bool spawning;
    private bool spawning2;
    private bool spawning3;
    
    public float spawnRate;
    public Transform position_;
    public Vector3 _postion;
    public Quaternion _rotation;

    public Text text;
    public string text_;
    public IntData score;
    public Image scorebar;
    public GameObject scorebar_;
    public GameObject Textbar_;
    public Animator animator;
    public bool cowIsWalking;
    public bool cowIsChilling;
    public bool cowIsScared;
    public bool cowIsDying;
    public bool cowIsDead;
    public CowHealth cowHealth_;
    public int currentCowHealth_;
    public GameObject Cow_;
    public Vector3 new_scale;
    public int Timer = 0;
    public int HowManyCanDie = 30;
    public GameObject healthobj_;
    public HealthClamp healthtoGameOver;
    public GameObject score_;
    public void Start()
    {
        cowHealth_ =this.gameObject.GetComponent<CowHealth>();
        scorebar_ = GameObject.FindGameObjectWithTag("Score bar");
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        scorebar = scorebar_.GetComponent<Image>();
        text = Textbar_.GetComponent<Text>();
        Cow_ =  GameObject.FindGameObjectWithTag("COW ALIVE");
        animator = Cow_.GetComponent<Animator>();
        cowIsChilling = animator.GetBool("cow is chilling");
        cowIsScared = animator.GetBool("cow is scared");
        cowIsDying = animator.GetBool("cow is being eaten");
        cowIsDead = animator.GetBool("cow dead");
        cowIsDead = false;
     

    }

    public void Update()
    {
        healthobj_ =  GameObject.FindGameObjectWithTag("health obj");
        healthtoGameOver = healthobj_.GetComponent<HealthClamp>();
        _postion = position_.position;
        _rotation = position_.rotation;
        currentCowHealth_ = cowHealth_.cowHealth_;
        text.text = score.value.ToString(); 
     
    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Fuzzy")
        {

            if(currentCowHealth_ <= 0)
            {
                Timer = +1;

                if (Timer <= 1)
                {

                    score.value += 1;
                    healthtoGameOver.AddTotHealth();
                    StartCoroutine(cowScared());
                    Timer = 0;
                }

            }

        }

    }


public IEnumerator Killcow2()
 {
      Destroy(deadcow);
      deadcow2 = Instantiate(deadcow2, _postion, _rotation) as GameObject;
      deadcow2.transform.parent = gameObject.transform;
      yield return new WaitForSeconds(.5f);
      spawning2 = false;

 }
    public IEnumerator Killcow3()
    {
       yield return new WaitForSeconds(.1f);
       spawning3 = false;
       this.gameObject.SetActive(false);
    }

    public void cowIdle()
    {
        cowIsChilling = true;
    }

    public IEnumerator cowScared()
    {
        cowIsScared = true;
        yield return new WaitForSeconds(.1f);
        StartCoroutine(cowDying());
        StartCoroutine(Killcow2());
        cowIsDying = true;
    }
    public IEnumerator cowDying()
    {
        cowIsDying = true;
        yield return new WaitForSeconds(.1f);
        cowIsDying = false;
        StartCoroutine(Killcow3());
        cowIsDead = true;
    }

 
}