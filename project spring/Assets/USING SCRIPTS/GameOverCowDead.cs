using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverCowDead : MonoBehaviour
{

    public GameObject[] cowsAlive_;
    public GameObject[] cowsdead;
    public GameObject cow;
    public int liveamount=5;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {


    
    }

    // Update is called once per frame
    void Update()
    {
        cowsdead = GameObject.FindGameObjectsWithTag("dead cowww");
        cowsAlive_ = GameObject.FindGameObjectsWithTag("Cowbox");


        if (cowsAlive_.Length >= liveamount)
        {
            isAlive = true;

        }


        if (isAlive)
        {
            if (cowsdead.Length == cowsAlive_.Length)
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

