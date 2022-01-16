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
    public bool cowAwake;
    public bool cowMoving;
    public bool cowIsDead;

    public GameObject Cow_forAnimation;
    
    public void Start()
    {

     
        scorebar_ = GameObject.FindGameObjectWithTag("Score bar");
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        position_ = this_gamObj2.GetComponent<Transform>();
        scorebar = scorebar_.GetComponent<Image>();
        text = Textbar_.GetComponent<Text>();
        Cow_forAnimation =  GameObject.FindGameObjectWithTag("COW ALIVE");
        animator = Cow_forAnimation.GetComponent<Animator>();
        
        cowIsChilling = animator.GetBool("cow is chilling");
        cowIsScared = animator.GetBool("cow is scared");
        cowIsDying = animator.GetBool("cow is being eaten");
        

        cowIsDead = animator.GetBool("cow dead");

        StartCoroutine(cowWalking());
        cowWalking();

    }
    // Update is called once per frame
    public void Update()
    {
       
        _postion = position_.position;
        _rotation = position_.rotation;
      
     
        text.text = score.value.ToString();
        scorebar.fillAmount = score.value;

    }

    public void Awake()
    {
        StartCoroutine(cowWalking());
        cowWalking();
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Fuzzy")
        {

            cowIsChilling = false;
            StartCoroutine(cowScared()); 
            cowScared();

        }

        if(cowIsDead)
        {
            StartCoroutine(Killcow());
            Killcow();
            //  this_gamObj.SetActive(false);
            score.value += 1;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fuzzy")
        {

            // Destroy(deadcow2);
        }
    }



    public IEnumerator Killcow()
    {
        deadcow = Instantiate(deadcow, _postion, _rotation) as GameObject;
        deadcow.transform.parent = gameObject.transform;
        Destroy(deadcow, 4f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
        StartCoroutine(Killcow2());
        Killcow2();
       

    }
    public IEnumerator Killcow2()
    {
        deadcow2 = Instantiate(deadcow2, _postion, _rotation) as GameObject;
        deadcow2.transform.parent = gameObject.transform;
        Destroy(deadcow, 4f);
        yield return new WaitForSeconds(spawnRate);
        spawning2 = false;
        StartCoroutine(Killcow3());
        Killcow3();

    }
    public IEnumerator Killcow3()
    {
        deadcow3 = Instantiate(deadcow3, _postion, _rotation) as GameObject;
        deadcow3.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(spawnRate);
        spawning3 = false;

    }

    public IEnumerator cowWalking()
    {
        cowAwake = true;
         yield return new WaitForSeconds(3);
        cowAwake = false;
       
        cowIdle();

    }
    public void cowIdle()
    {
        cowIsChilling = true;
    
    }

    public IEnumerator cowScared()
    {
        cowIsScared = true;
        yield return new WaitForSeconds(4);
        cowIsScared = false;
        StartCoroutine(cowDying());
        cowDying();
        cowIsDying = true;
    }
    public IEnumerator cowDying()
    {
        cowIsDying = true;
        yield return new WaitForSeconds(4);
        cowIsDying = false;
    
        cowIsDead = true;
    }
}