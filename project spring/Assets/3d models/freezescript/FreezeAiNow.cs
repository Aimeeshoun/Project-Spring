using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAiNow : MonoBehaviour
{

    public ClickonRods clickonRods_;
    public GameObject[] rods;

    public bool isClicked;
    public bool isclicked2;
    public bool isclicked3;

    public int Timer;
    public ClickFreeze freeze_;
    public bool timeron;
    public bool isCrisp_;
    public bool yellowyes;
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        rods = GameObject.FindGameObjectsWithTag("rod");
    //    yellowyes = false;
        foreach (GameObject rod in rods)
        {

           

            clickonRods_ = rod.GetComponent<ClickonRods>();
            freeze_ = rod.GetComponent<ClickFreeze>();
            isClicked = clickonRods_.isclickedon;
            isCrisp_ = freeze_.isCrisp;

           if (isClicked)
            {
                StartCoroutine(Freeze());
                Freeze(); ;
            }


            if (isCrisp_)
            {
                yellowyes = true;
            }

           


        }





    }

    IEnumerator Freeze()
    {
        //Print the time of when the function is first called.
        isclicked3 = true;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        isclicked3 = false;

    }
}