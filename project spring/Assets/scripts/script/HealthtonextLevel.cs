using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthtonextLevel : MonoBehaviour
{



    public IntData aliensDead;

    public int valueOfAlienDead = 30;
    public killfuzzy grabIntData_;
    public GameObject alienAlive_;
    public GameObject Textbar_;
    public Text text;
    public string scoreee;
    
    // Start is called before the first frame update
    public void Start()
    {


        aliensDead.value = 0;
        Textbar_ = GameObject.FindGameObjectWithTag("text score 2");
        text = Textbar_.GetComponent<Text>();




    }

    // Update is called once per frame
    public void Update()
    {

        alienAlive_ = GameObject.FindGameObjectWithTag("Fuzzy");
     
        grabIntData_ = alienAlive_.GetComponent<killfuzzy>();
        aliensDead = grabIntData_.alienScore;
        scoreee = aliensDead.ToString();
        text.text = aliensDead.value.ToString();
        if (aliensDead.value >= valueOfAlienDead)
        {
            //      NextLevel();

        }

    }

  //  public void NextLevel()
  //  {
     //   SceneManager.LoadScene("Level 2");
  //  }


}
