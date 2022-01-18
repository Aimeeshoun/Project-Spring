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

    public GameObject Cow_forAnimation;
    public GameObject eye_ball;
    public GameObject eye_ball2;
    public GameObject eye_ball3;
    public Transform eye_ball_;

    public Vector3 new_scale;
    public int Timer = 0;

    public void Start()
    {
  
       scorebar_ = GameObject.FindGameObjectWithTag("Score bar");
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        
        scorebar = scorebar_.GetComponent<Image>();
        text = Textbar_.GetComponent<Text>();
        Cow_forAnimation =  GameObject.FindGameObjectWithTag("COW ALIVE");
        eye_ball = GameObject.FindGameObjectWithTag("eyeball");
        eye_ball_ = eye_ball.GetComponent<Transform>();
        

        animator = Cow_forAnimation.GetComponent<Animator>();
        
        cowIsChilling = animator.GetBool("cow is chilling");
        cowIsScared = animator.GetBool("cow is scared");
        cowIsDying = animator.GetBool("cow is being eaten");
        

        cowIsDead = animator.GetBool("cow dead");
        cowIsDead = false;
        
       
    }
    // Update is called once per frame
    public void Update()
    {
       
        _postion = position_.position;
        _rotation = position_.rotation;
      
     
        text.text = score.value.ToString();
        scorebar.fillAmount = score.value;
        
    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Fuzzy")
        {
            Timer = 1;

            if(Timer == 1)
            {
                score.value += 1;
                Timer = 0;
                //new_scale = new Vector3(2, 2, 2);
                // eye_ball.transform.localScale += new_scale;
                StartCoroutine(cowScared());
            }
            
    
            

        }

        if(cowIsDead)
        {
            
           
            
                StartCoroutine(Killcow());
           //   Killcow();
          
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
        Instantiate(eye_ball2, eye_ball.transform.position, eye_ball.transform.rotation);
        //eye_ball3.transform.parent = eye_ball.transform;
        eye_ball2.transform.SetParent(eye_ball_);
        yield return new WaitForSeconds(1);
      
        spawning = false;
        
        
       


    }
public IEnumerator Killcow2()
 {
      Destroy(deadcow);
      deadcow2 = Instantiate(deadcow2, _postion, _rotation) as GameObject;
      deadcow2.transform.parent = gameObject.transform;
     
      yield return new WaitForSeconds(4);
     spawning2 = false;
  

 }
    public IEnumerator Killcow3()
    {
        deadcow3 = Instantiate(deadcow3, _postion, _rotation) as GameObject;
        deadcow3.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(2);
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
        yield return new WaitForSeconds(2);
    
        StartCoroutine(cowDying());
        StartCoroutine(Killcow2());
        cowIsDying = true;
    }
    public IEnumerator cowDying()
    {
        cowIsDying = true;

        yield return new WaitForSeconds(1);
        cowIsDying = false;
      
        StartCoroutine(Killcow3());
        cowIsDead = true;
    }
}