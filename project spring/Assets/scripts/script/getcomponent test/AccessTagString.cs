using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTagString : MonoBehaviour
{

    public string MyName;
    public bool shoe;
    public bool second_gun;
    public bool hat;
    public bool water_gun;
    public bool gumball;
    public bool ball;
    public bool surge;
    public bool burger;
    public bool heart;
    public bool clown;
    public bool pony;
    public bool alien;
    public bool devil;
    public bool kitty;
    public bool jelly;
    public bool pink_pony;
    public bool octopus;
    public bool norwhale;
    public bool skull;



    public enum WeaponType
    {
        shoe,
        second_gun,
        hat,
        water_gun,
        gumball,
        ball,
        surge,
        burger,
        heart
    }

    public enum CharacterType
    {
        clown,
        pony,
        alien,
        devil,
        kitty,
        jelly,
        pink_pony,
        octopus,
        norwhale,
        skull
    }


    public string[] weapons = new string[9];
    public string[] weaponSel = new string[9];
    public string[] characters = new string[10];
    public string[] characterSel = new string[10];

    //weapons[0]
   // weaponSel[0]
    //characters[0]
    //characterSel[0]



    void CurrentWeapon()
    {
        if (shoe)
        {

        }
        if (second_gun)
        {

        }
        if (hat)
        {

        }
        if (water_gun)
        {

        }
        if (gumball)
        {

        }
        if (ball)
        {

        }
        if (surge)
        {

        }
        if (burger)
        {

        }
        if (heart)
        {

        }
        if (clown)
        {

        }
        if (pony)
        {

        }
        if (alien)
        {

        }
        if (devil)
        {

        }
        if (kitty)
        {

        }
        if (jelly)
        {

        }
        if (pink_pony)
        {

        }
        if (octopus)
        {

        }
        if (norwhale)
        {

        }
        if (skull)
        {

        }
       // if (!skull)    //if not skull
       // {

       // }

    }
















    [SerializeField]
    private WeaponType weaponType;

    [SerializeField]
    private CharacterType characterType;



 


    // Start is called before the first frame update
    void Start()
    {
        PrintName(MyName);
        print("Raja");
    }

    // Update is called once per frame
    void Update()

    {

        if (this.gameObject.name == "Raja")
        {
            print("Raja");
        }
        else {

            print("you are not RAja");
                

        }


    
        DoStuffBasedOnType(weaponType);
    } 
        private void DoStuffBasedOnType(WeaponType weaponType)
        {

        }
  
    int GiveDouble(int val)
    {
        return (val * 2);
    }

    void PrintName(string name)
{
        print("My name is" + name);
}

   



}
