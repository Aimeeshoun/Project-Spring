using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;

    int score = 0;


    bool gameOver = false;

    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    public void IncrementScore()
    {
        score = score++;
        
        scoreText.text = score.ToString();
        print(score);

    }


}
