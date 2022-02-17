using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{



    public Text scoreText;
    public GameObject Text_;
    public string String_time;
    public TIMER timer_;
    public int Time_;
    public GameObject The_Text;



    public void Start()
    {
         Text_ = GameObject.FindGameObjectWithTag("TIMER2");
         timer_ = Text_.GetComponent<TIMER>();


          The_Text = GameObject.FindGameObjectWithTag("timer");
          scoreText = The_Text.GetComponent<Text>();

    }


    public void Update()
    {
  

     Time_ = timer_.current_time;

        scoreText.text = Time_.ToString();
    }
}




