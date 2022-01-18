using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthtoGameOver : MonoBehaviour
{


    public IntData cowsDead;
   
    public int valueOfDead=100;
    public InstanciteDeadCow2 grabIntData_;
    public GameObject cowAlive_;
    public GameObject Textbar_;
    public Text text;

    
    // Start is called before the first frame update
    void Start()
    {
        cowAlive_ = this.gameObject;
       grabIntData_ = cowAlive_.GetComponent<InstanciteDeadCow2>();
        cowsDead = grabIntData_.score;
  
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        text = Textbar_.GetComponent<Text>();
    



    }

    // Update is called once per frame
    void Update()
    {
    //    text.text = cowsDead.value.ToString();

        if (cowsDead.value == valueOfDead)
        {
            GameOverScene();

        }
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("game over scene");
    }
}
