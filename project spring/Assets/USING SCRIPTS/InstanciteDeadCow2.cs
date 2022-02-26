using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciteDeadCow2 : MonoBehaviour
{

    public GameObject deadcow;
    public GameObject deadcow2;
    public GameObject deadcow3;
    private bool spawning2;
    private bool spawning3;
    public Transform position_;
    public Vector3 _postion;
    public Quaternion _rotation;
    public Text text;
    public IntData score;
    public Image scorebar;
   public GameObject scorebar_;
    public GameObject Textbar_;
    public Animator animator;
    public bool cowIsChilling;
    public bool cowIsScared;
    public bool cowIsDying;
    public bool cowIsDead;
   public CowHealth cowHealth_;
    public int currentCowHealth_;
 //  public GameObject Cow_;
   public GameObject[] Cows_;
    public GameObject[] Cows2_;
    public GameObject deadCow_;
    public GameObject[] deadCows_;
    public int Timer = 0;
    public GameObject healthobj_;
    public HealthClamp healthtoGameOver;
    public bool iseaten;
   public GameObject thisGameobject;
   public GameObject thisGameobjects;


   public GameObject cow1;
  public GameObject cow2;

    public void Start()
    {
        
    //    scorebar_ = GameObject.FindGameObjectWithTag("Score bar");
    //    Textbar_ = GameObject.FindGameObjectWithTag("Text score");
   //     scorebar = scorebar_.GetComponent<Image>();
      //  text = Textbar_.GetComponent<Text>();

      


    }
    public void Awake()
    {
        iseaten = false;


    }
    public void Update()
    {
        cowHealth_ = this.gameObject.GetComponent<CowHealth>();
        Cows2_ = GameObject.FindGameObjectsWithTag("COW ALIVE");

        foreach ( GameObject cow2_ in Cows2_)
        {
            animator = cow2_.GetComponent<Animator>();
            cowIsChilling = animator.GetBool("cow is chilling");
            cowIsScared = animator.GetBool("cow is scared");
            cowIsDying = animator.GetBool("cow is being eaten");
           cowIsDead = animator.GetBool("cow dead");
        }
        Cows_ = GameObject.FindGameObjectsWithTag("Cowbox");
        foreach (GameObject Cow_ in Cows_)
        {



            if (!Cow_ == null)
            {
              
                cowIsDead = false;
   
                cowHealth_= Cow_.GetComponent<CowHealth>();

                currentCowHealth_ = cowHealth_.cowHealth_;
                //       return;
            }
        }
        healthobj_ = GameObject.FindGameObjectWithTag("health obj");
        healthtoGameOver = healthobj_.GetComponent<HealthClamp>();
        _postion = position_.position;
        _rotation = position_.rotation;
       
       
      //  text.text = score.value.ToString();

    }


    private void OnTriggerEnter(Collider other)
    { 

        if (other.tag == "Fuzzy")
        {
            thisGameobject = this.gameObject;

            if (currentCowHealth_ <= 0)
            {
                Timer = +1;

                if (Timer == 1)
                {

                    score.value += 1;
                    healthtoGameOver.AddTotHealth();
                    StartCoroutine(cowScared());
                    if (iseaten == true)
                    {
                       
                        
                
                        Destroy(thisGameobject);

                        //  foreach (GameObject deadcow in deadCows_)
                        //   {
                        //       cow1 = deadcow;
                        //     Destroy(cow1);
                        //   }
                        //  foreach (GameObject cow in Cows_)
                        //  {
                        //     cow2 = cow;
                        //     Destroy(cow2);
                    }

                    Timer = 0;
                }

            }

        }

    }


    public void Killcow2()
    {
        if (!deadcow2==null) { 
        Destroy(deadcow);
        deadcow3 = Instantiate(deadcow2, _postion, _rotation) as GameObject;
        deadcow3.transform.parent = gameObject.transform;
        spawning2 = false;
    }
}
    public IEnumerator Killcow3()
    {

        yield return new WaitForSeconds(.2f);
        iseaten = true;
        spawning3 = false;

    }

    public void cowIdle()
    {
        cowIsChilling = true;
    }

    public IEnumerator cowScared()
    {
        cowIsScared = true;
        yield return new WaitForSeconds(.2f);
        StartCoroutine(cowDying());
        Killcow2();
        cowIsDying = true;
    }
    public IEnumerator cowDying()
    {
        cowIsDying = true;
        yield return new WaitForSeconds(.2f);
        cowIsDying = false;
        StartCoroutine(Killcow3());
        cowIsDead = true;
    }



}
