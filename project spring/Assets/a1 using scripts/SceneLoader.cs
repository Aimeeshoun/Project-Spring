using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
       // SceneManager.LoadScene("start scene");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("start scene");
    }

    public void InstructionScene()
    {
        SceneManager.LoadScene("instruction menu");
    }

    public void TryagainScene()
    {
        SceneManager.LoadScene("game over menu");
    }

    public void GameOverScene()
    {
        SceneManager.LoadScene("game over scene");
    }
    public void PlayScene()
    {
        SceneManager.LoadScene("play scene");
    }
  //  public void LoadingScene()
  //  {
  //      SceneManager.LoadScene("loading scene");
  //  }
   // public void TransitiongScene()
   // {
   //     SceneManager.LoadScene("transitional scene");
   // }

    public void Exit()
   {
        Application.Quit();
    }
}
