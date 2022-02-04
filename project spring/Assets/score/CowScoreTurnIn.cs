using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScoreTurnIn : MonoBehaviour
{

    public IntData CowTurnInNumber;
    public GameObject destroy_box;

    public GameObject ScoreBox;

    public GameObject cow_destroyed;

    public Text text;

    public int newScore;
    public ObjectTransform objectTransform_;

    public GameObject int_data;
    public int Timer=0;
    public int Timer2 = 0;

    public int Score;

    public GameObject other_gameObj;
    // Start is called before the first frame update
    void Start()
    {
       // CowTurnInNumber = ScoreBox.GetComponent<IntData>();
        ScoreBox = GameObject.FindGameObjectWithTag("cow turn in text");
        text = ScoreBox.GetComponent<Text>();
        CowTurnInNumber = int_data.GetComponent<IntData>();
        objectTransform_ = objectTransform_.GetComponent<ObjectTransform>();
        Score = CowTurnInNumber.value;


    }

    // Update is called once per frame
    void Update()
    {
       
        text.text = CowTurnInNumber.value.ToString();
      // if(objectTransform_.istriggered == true)
       // {
         //   Timer = 1;
         //   if (Timer == 1)
          //  {
          //      UpdateScore();
           //     Timer = 0;
           // }
      //  }
        
    

    }

    public void UpdateScore()
    {
        // Timer2 = 1;
        //  if (Timer2 == 1)
        //  {
        CowTurnInNumber.value += 1;
        if (other_gameObj.tag == "destroybox")
        {
            if (objectTransform_.istriggered == true)
            {
                Timer2 = 1;
                if (Timer2 == 1)
                {
                   UpdateScore();
                    Timer2 = 0;
                }
               
            }

        }
        //     Timer2 = 0;
        //  }
    }

    private void OnTriggerEnter(Collider other)
    {
        other_gameObj= other.gameObject;
     
    }
}

