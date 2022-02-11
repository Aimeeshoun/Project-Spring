using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthtoGameOver : MonoBehaviour
{


    public IntData cowsDead;

    public int valueOfDead;
    public InstanciteDeadCow2 grabIntData_;
    public GameObject[] cowAlives_;
    public GameObject[] cowsdead;
    public GameObject cowAlive_;
    public GameObject Textbar_;
    public Text text;
    public string scoreee;
    public bool isAlive;



    // Start is called before the first frame update
    public void Start()
    {


        cowsDead.value = 0;
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        text = Textbar_.GetComponent<Text>();




    }

    // Update is called once per frame
   public void Update()
    {
        
    //    cowAlives_ = GameObject.FindGameObjectsWithTag("dead cowww");
   //     valueOfDead = cowAlives_.Length;
   //     foreach(GameObject cowAlive_ in cowAlives_)
   //     {
   //         grabIntData_ = cowAlive_.GetComponent<InstanciteDeadCow2>();
   //         cowsDead = grabIntData_.score;
   //         scoreee = cowsDead.ToString();
           
    //    }
    //    text.text = cowsDead.value.ToString();
   //     if (cowsDead.value == valueOfDead)
   //     {
   //         GameOverScene();

 //       }
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