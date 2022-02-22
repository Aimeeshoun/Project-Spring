using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTimer : MonoBehaviour
{

    public int Time;
    public int newTimer = 0;
    public int current_time;
    public GameObject time_obj;
    public TIMER timer_;
    public int time_int;

    // Start is called before the first frame update
    void Start()
    {
        time_obj= GameObject.FindGameObjectWithTag("TIMER2");
        timer_ = time_obj.GetComponent<TIMER>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        time_int = timer_.current_time;

        if (time_int == 200000)
        {
            SceneManager.LoadScene("reward screen");
        }
    }
}


