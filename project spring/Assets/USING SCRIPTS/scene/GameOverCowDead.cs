using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverCowDead : MonoBehaviour
{

    public GameObject[] cowsAlive_;
    public GameObject[] cowsdead;
    public object cow;
 
    public bool isAlive;

    void Update()
    {

      

        cowsAlive_ = GameObject.FindGameObjectsWithTag("Cowbox");

       
            isAlive = true;
       

        if (isAlive)
        {
            if (cowsAlive_.Length == 0)
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

