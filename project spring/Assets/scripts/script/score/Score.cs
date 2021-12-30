using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    public IntData score;



    public Text scoreText;


    private void Update()
    {

        IncrementScore();
    }


    public void IncrementScore()
    {
        
        scoreText.text = score.ToString();
        print(score);

    }


   
}






