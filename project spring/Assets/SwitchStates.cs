using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStates : MonoBehaviour



{

    public enum gameStates { cowWalking, CowIdle, CowScared, CowDead }
    public gameStates currentState = gameStates.cowWalking;

    // Use this for initialization
    void Start()
    {
        switch (currentState)
        {
            case gameStates.cowWalking:
                DoSomething("cow walking", gameStates.CowIdle);
                break;

            case gameStates.CowIdle:
                DoSomething("cow idle", gameStates.CowScared);
                break;
            case gameStates.CowScared:
                DoSomething("cow scared", gameStates.CowDead);
                break;
            case gameStates.CowDead:
                DoSomething("cow dead", gameStates.CowDead);
                break;

        }


         void DoSomething(string v, gameStates gs)
        {
            print("The game is " + v);
            if (gs != gameStates.CowIdle)
                Start();
            currentState = gs;
        }
    }
}
// AnthonyRomrell Github with modifications 