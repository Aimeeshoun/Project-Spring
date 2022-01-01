using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringScoreZero : MonoBehaviour

{ 



public IntData scoreValue;

public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = scoreValue.value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {


        MakeScoreZero();

    }

    public void MakeScoreZero()
    {


        scoreValue.value = 0;



    }
}