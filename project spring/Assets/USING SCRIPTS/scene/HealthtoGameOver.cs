using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthtoGameOver : MonoBehaviour
{


    public IntData cowsDead;
    public int valueOfDead;
    public GameObject[] cowAlives_;
    public GameObject[] cowsdead;
    public GameObject Textbar_;
    public Text text;
    public bool isAlive;
    public void Start()
    {

        cowsDead.value = 0;
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        text = Textbar_.GetComponent<Text>();

    }

   public void Update()
    {
        cowAlives_ = GameObject.FindGameObjectsWithTag("dead cowww");
        cowsdead = GameObject.FindGameObjectsWithTag("dead cowww");
        cowAlives_ = GameObject.FindGameObjectsWithTag("Cowbox");

        if (cowAlives_.Length >= valueOfDead)
        {
            isAlive = true;

        }


        if (isAlive)
        {
            if (cowsdead.Length == cowAlives_.Length)
            {
                GameOverScene();

            }
        }

    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("game over menu");
    }
}