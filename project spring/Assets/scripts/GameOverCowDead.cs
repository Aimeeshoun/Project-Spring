using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverCowDead : MonoBehaviour
{

    public GameObject[] cowsAlive_;
    public GameObject[] cowsdead;
    public GameObject cow;
    public int liveamount=2;

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

