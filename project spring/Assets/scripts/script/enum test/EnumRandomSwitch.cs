using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class EnumRandomSwitch: MonoBehaviour

{


    public enum States
    {
        Weapon1,
        Weapon2,
        Weapon3,
        Weapon4,
        Weapon5,
        Weapon6,
        Weapon7,
        Weapon8,
        Weapon9,
        Weapon10,
    }

    public States currentState;

    public UnityEvent OnWeapon1Event, OnWeapon2Event, OnWeapon3Event, OnWeapon4Event, OnWeapon5Event, OnWeapon6Event, OnWeapon7Event, OnWeapon8Event, OnWeapon9Event, OnWeapon10Event;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Weapon1:
                OnWeapon1Event.Invoke();
                break;
            case States.Weapon2:
                OnWeapon2Event.Invoke();
                break;
            case States.Weapon3:
                OnWeapon3Event.Invoke();
                break;
            case States.Weapon4:
                OnWeapon4Event.Invoke();
                break;
            case States.Weapon5:
                OnWeapon5Event.Invoke();
                break;
            case States.Weapon6:
                OnWeapon6Event.Invoke();
                break;
            case States.Weapon7:
                OnWeapon7Event.Invoke();
                break;
            case States.Weapon8:
                OnWeapon8Event.Invoke();
                break;
            case States.Weapon9:
                OnWeapon9Event.Invoke();
                break;
            case States.Weapon10:
                OnWeapon10Event.Invoke();
                break;






        }

    }
}
