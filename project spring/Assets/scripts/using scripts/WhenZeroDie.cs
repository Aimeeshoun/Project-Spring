using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhenZeroDie : MonoBehaviour
{
    public IntData score;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {


        if (score.value == 0)
        {
            KillPlayer();
        }
    
   
     
    }


     void KillPlayer()
    {
        TryagainScene();

    }
    public void TryagainScene()
    {
        SceneManager.LoadScene("game over menu");
    }


}