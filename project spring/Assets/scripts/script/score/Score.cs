using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    int score = 0;



    public Text scoreText;





    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
        print(score);

    }


   
}






