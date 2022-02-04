using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowScoreTurnIn : MonoBehaviour
{

    public IntData CowTurnInNumber;
    public GameObject destroy_box;

    public GameObject ScoreBox;

    public GameObject cow_destroyed;

    public Text text;




    // Start is called before the first frame update
    void Start()
    {
        CowTurnInNumber = ScoreBox.GetComponent<IntData>();
    
    }

    // Update is called once per frame
    void Update()
    {
          CowTurnInNumber.value.ToString();


    }

    public void UpdateScore()
    {
        CowTurnInNumber.value += 1;
    }


}
