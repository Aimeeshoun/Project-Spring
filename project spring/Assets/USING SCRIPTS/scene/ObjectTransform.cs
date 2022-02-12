using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{

    public GameObject this_obj;
    public Transform obj_trans;
    public Vector3 obj_position;
    public Quaternion obj_rotation;
    public GameObject other_obj;
    public GameObject child_obj;
   public enum gameStates { cowChilling, CowAttached, CowTurnIn }
    public gameStates currentState = gameStates.cowChilling;
    public GameObject CowScoreBox;
    public CowScoreTurnIn cowscore;


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

    void Update()
    {
        this_obj = this.gameObject;
        if (other_obj.tag == "cowww")
        {
            currentState = gameStates.CowAttached;
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

                break;

            case gameStates.CowTurnIn:

                child_obj.SetActive(false);

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

    }


}
