using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    public IntData scoreValue;
 
    public Text text;

    private void Start()
    {
        text = text.GetComponent<Text>();
   
    }

    private void Update()
    {
        text.text = scoreValue.value.ToString();

    }


    private void OnTriggerEnter(Collider other)
    {

     

            AddScores();
        
    }

    public void AddScores()
    {

      



            scoreValue.value = scoreValue.value + 1;



    }
}




