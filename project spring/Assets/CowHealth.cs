using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowHealth : MonoBehaviour
{

    public int cowHealth_;
    public int cowMaxHealth_;
    public cHANGEcOLOR cHANGcolor_;

    public GameObject gameObject_;

    public Material material_;
    public Material material2_;


    //  public IntData cowMaxHealth_;

    //**** MAKE INTO INTDATA FOR MUILTI LEVELS  

    int Timer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }
    public void Awake()
    {
        gameObject_ = GameObject.FindGameObjectWithTag("cow");

        cHANGcolor_ = gameObject_.GetComponent<cHANGEcOLOR>();
        material_ = cHANGcolor_.the_mat;
        material2_ = cHANGcolor_.the_mat2;
    }



    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Fuzzy")
        {
            Timer++;
            if (Timer <= 1)
            {


                cowHealth_ -= 1;
                StartCoroutine(ChangeColor());

                Timer = 0;
            }
            StartCoroutine(ChangeBackColor());
            if (cowHealth_ <= 0)
            {
                cowHealth_ = 0;
            }


        }

    }
    public IEnumerator ChangeColor()
    {

        //  the_mats[0] = the_mat2;

        gameObject_.GetComponent<Renderer>().material = material_;
        yield return new WaitForSeconds(1f);




    }

    public IEnumerator ChangeBackColor()
    {
        //the_mats[0] = the_mat;
        yield return new WaitForSeconds(1f);
        gameObject_.GetComponent<Renderer>().material = material2_;



    }
}