using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CurrentCharEnum : MonoBehaviour

{


    public enum States
    {
        Character1,
        Character2,
        Character3,
        Character4,
        Character5,
        Character6,
        Character7,
        Character8,
        Character9,
        Character10,
    }

    public States currentState;

    public UnityEvent OnCharacter1Event, OnCharacter2Event, OnCharacter3Event, OnCharacter4Event, OnCharacter5Event, OnCharacter6Event, OnCharacter7Event, OnCharacter8Event, OnCharacter9Event, OnCharacter10Event;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Character1:
                OnCharacter1Event.Invoke();
                break;
            case States.Character2:
                OnCharacter2Event.Invoke();
                break;
            case States.Character3:
                OnCharacter3Event.Invoke();
                break;
            case States.Character4:
                OnCharacter4Event.Invoke();
                break;
            case States.Character5:
                OnCharacter5Event.Invoke();
                break;
            case States.Character6:
                OnCharacter6Event.Invoke();
                break;
            case States.Character7:
                OnCharacter7Event.Invoke();
                break;
            case States.Character8:
                OnCharacter8Event.Invoke();
                break;
            case States.Character9:
                OnCharacter9Event.Invoke();
                break;
            case States.Character10:
                OnCharacter10Event.Invoke();
                break;
        }

    }
}





