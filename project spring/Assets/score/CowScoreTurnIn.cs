using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CowScoreTurnIn : MonoBehaviour
{

    public IntData CowTurnInNumber;
    public GameObject destroy_box;
    public int CowthatAreTurnedin = 1;
    public GameObject ScoreBox;

    public GameObject cow_destroyed;

    public Text text;

    public int newScore;
    public ObjectTransform objectTransform_;

    public GameObject int_data;
    public int Timer=0;
    public int Timer2 = 0;

    public int Score=0;

    public GameObject other_gameObj;
    // Start is called before the first frame update
    void Start()
    {
       // CowTurnInNumber = ScoreBox.GetComponent<IntData>();
        ScoreBox = GameObject.FindGameObjectWithTag("cow turn in text");
        text = ScoreBox.GetComponent<Text>();
        CowTurnInNumber = int_data.GetComponent<IntData>();
        objectTransform_ = objectTransform_.GetComponent<ObjectTransform>();

        CowTurnInNumber.value = Score;

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

        if (other_gameObj.tag == "turn in")
        {
            //  if (objectTransform_.istriggered == true)
            //  {
            Timer = 1;
            if (Timer == 1)
            {
                UpdateScore();
                Timer = 0;
            }

            //  }
            Timer = 0;
        }
        Timer = 0;
        if (CowTurnInNumber.value == 5)
        {
            SceneManager.LoadScene("level 2");

        }
        if (CowTurnInNumber.value == 10)
        {
            SceneManager.LoadScene("level 3");

        }
        if (CowTurnInNumber.value == 20)
        {
            SceneManager.LoadScene("level 4");

        }
        if (CowTurnInNumber.value == 30)
        {
            SceneManager.LoadScene("level 5");

        }
   
    }

    public void UpdateScore()
    {
        
         if (Timer2 == 1)
          {
        CowTurnInNumber.value += 1;

            Timer2 = 0;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Timer2 = 1;

        other_gameObj = other.gameObject;
     
    }

    private void OnTriggerExit(Collider other)
    {
        Timer2 = 0;
    }

  
  
}


