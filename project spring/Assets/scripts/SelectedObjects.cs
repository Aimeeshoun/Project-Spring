using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjects : MonoBehaviour

{


    public gameObject weapon1;
    public gameObject weapon2;
    public gameObject weapon3;
    public gameObject weapon4;
    public gameObject weapon5;
    public gameObject weapon6;
    public gameObject weapon7;
    public gameObject weapon8;
    public gameObject weapon9;
    public gameObject weapon10;
    WeaponList myWAL = new ArrayList();


    public  void OnStart()

    { 


        myWAL.Add("weapon1");
        myWAL.Add("weapon2");
        myWAL.Add("weapon3");
        myWAL.Add("weapon4");
        myWAL.Add("weapon5");
        myWAL.Add("weapon6");
        myWAL.Add("weapon7");
        myWAL.Add("weapon8");
        myWAL.Add("weapon9");
        myWAL.Add("weapon10");


    
        Print(myWAL);
 
}


