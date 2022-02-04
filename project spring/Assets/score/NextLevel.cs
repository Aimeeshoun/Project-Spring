using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    public IntData cowsScore;

    public int CowthatAreTurnedin = 1;
    public ScoreHolder grabIntData_;
    public GameObject cowTurnIN_;
    public GameObject Textbar_;
    public Text text;
    public string scoreee;

    // Start is called before the first frame update
    void Start()
    {
        cowsScore.value = 0;
        Textbar_ = GameObject.FindGameObjectWithTag("Text score");
        text = Textbar_.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cowTurnIN_ = GameObject.FindGameObjectWithTag("cow score level");
        grabIntData_ = cowTurnIN_.GetComponent<ScoreHolder>();
        cowsScore = grabIntData_.theCowScore;
        scoreee = cowsScore.ToString();
        text.text = cowsScore.value.ToString();
        if (cowsScore.value >= CowthatAreTurnedin)
        {
            SceneManager.LoadScene("level 2");

        }

    }

        public void NextScene()
        {
            SceneManager.LoadScene("level 2");
        }

    }




