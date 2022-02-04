using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
 public int  Timer = 0;
    public GameObject this_obj;
    public Transform obj_trans;
    public Vector3 obj_position;
    public Quaternion obj_rotation;

    public GameObject[] cows_;
    public GameObject[] boxes_;

    public GameObject currentcow__;


    public GameObject other_obj;
    public GameObject child_obj;


    public bool istriggered= false;

    public int Timer3 = 0;


    public enum gameStates { cowChilling, CowAttached, CowTurnIn }
    public gameStates currentState = gameStates.cowChilling;

    public GameObject CowScoreBox;
    public CowScoreTurnIn cowscore;

    // Start is called before the first frame update
    void Start()
    {
       currentState = gameStates.cowChilling;
        child_obj = this_obj.transform.GetChild(1).gameObject;

        cowscore = CowScoreBox.GetComponent<CowScoreTurnIn>();
     
    }
    private void Awake()
    {
     
        obj_trans= this_obj.transform;
        obj_position= obj_trans.position;
        obj_rotation = obj_trans.rotation;


        currentState = gameStates.cowChilling;

    }

    // Update is called once per frame
    void Update()
    {
        this_obj = this.gameObject;
       
        if (other_obj.tag == "cowww")
        {
            // InstanciateCowParent();
            //   DestroyObject();

            currentState = gameStates.CowAttached;

            //   Timer = 0;
        }
        if (other_obj.tag == "destroybox")
        {
            currentState = gameStates.CowTurnIn;
         
           
        }
       
            
        

        switch (currentState)
        {
            case gameStates.cowChilling:
                child_obj.SetActive(false);
                break;

            case gameStates.CowAttached:

                child_obj.SetActive(true);
                //  other_obj.SetActive(false);
                break;
            case gameStates.CowTurnIn:




                //    if (other_obj.tag == "turn in")
                //    {
                //       Timer3 = 1;
                //       if (Timer3 == 1)

                child_obj.SetActive(false);
                //       {
                //          istriggered = true;
                
              //          Timer3 = 0;
              //      }
              //      istriggered = false;
                
         //       }
               

                break;


        }




    }
    private void OnTriggerEnter(Collider other)
    {
        other_obj= other.gameObject;

        if(other_obj.tag == "destroybox")
        {
            cowscore.UpdateScore();

        }

        //   if (other_obj.tag == "boxes")
        //  {
        //      this_obj = this.gameObject;
        //     obj_trans = this_obj.transform;
        //     obj_position = obj_trans.position;
        //    obj_rotation = obj_trans.rotation;
        //  }

        //    if (other_obj.tag == "cowww")
        //    {
        //       this_obj = this.gameObject;
        //      obj_trans = this_obj.transform;
        //      obj_position = obj_trans.position;
        //     obj_rotation = obj_trans.rotation;
        //    Timer = 1;
        //    child_obj.SetActive(true);



        //  currentcow__ = Instantiate(currentcow__, obj_position, obj_rotation);
        //   currentcow__.transform.parent = obj_trans;






    }
    //   public void DestroyObject()
    //  {
    //      Destroy(other_obj);
    //  }
    //  public void InstanciateCowParent()
    //  {
    //      currentcow__ = Instantiate ( currentcow__,  obj_position, obj_rotation)as GameObject; 
    //    currentcow__.transform.parent = obj_trans;
    //  }

}
