using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{


    public IntData theCowScore;
    public GameObject scoreHolder;
    public int CurrentValue=0;
    public Text text;

    public GameObject the_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreHolder = GameObject.FindGameObjectWithTag("cow score holder");
        the_text = GameObject.FindGameObjectWithTag("cow turn in text");
        theCowScore = scoreHolder.GetComponent<IntData>();
      
        text.text = theCowScore.value.ToString();
       
    }
}
