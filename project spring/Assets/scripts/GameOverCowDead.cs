using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverCowDead : MonoBehaviour
{

    public GameObject[] cowsAlive;
    public GameObject cow;

    // Start is called before the first frame update
    void Start()
    {
        cowsAlive= GameObject.FindGameObjectsWithTag("dead cowww");
    }

    // Update is called once per frame
    void Update()
    {
        if (cowsAlive.Length <= 0)
        {
            GameOverScene();

        }

    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("game over menu");
    }
}

