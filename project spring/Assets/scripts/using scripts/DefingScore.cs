using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefingScore : MonoBehaviour
{


    public IntData scoreValue;

    public Text text;



    // Start is called before the first frame update
    void Start()
    {
        text = text.GetComponent<Text>();
        text.text = scoreValue.value.ToString();
        scoreValue.value = 1;
    }

}
