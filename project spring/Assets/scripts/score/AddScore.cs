using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    public IntData scoreValue;

    public void AddScores()
    {
        scoreValue.value++;
    }
}

