using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    public IntData scoreValue;
    public bool isBeingdestroy;
    
    public Text text;

    private void Start()
    {
        text = text.GetComponent<Text>();
        AddScores();
    }

    private void Update()
    {
        text.text = scoreValue.value.ToString();
        AddScores();
    }


    public void AddScores()
    {

        if (isBeingdestroy)
        {




            scoreValue.value++;



        }
    }
}




