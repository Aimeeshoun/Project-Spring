using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfObject : MonoBehaviour
{

    public CollectionSO ColSOcharList;
    public CollectionSO ColSOweaList;
    public CollectionSO ColSOcharselList;
    public CollectionSO ColSOweaselList;
    
    public WeaponNUmber WeaNcharList;
    public WeaponNUmber WeaNweaList;
    public WeaponNUmber WeaNcharselList;
    public WeaponNUmber WeaNweaselList;
    
    public WeaponController WeaConcharList;
    public WeaponController WeaConweaList;
    public WeaponController WeacharselConList;
    public WeaponController WeaConweaselList;
 

    public InputField weaponselectTagInput;
    public InputField weaponTagInput;
    public InputField characterselectTagInput;
    public InputField characterTagInput;

    public bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CompareWeapons()
    {

        foreach (i in ColSOweaList)
        {
            if (weaponTagInput == weaponselectTagInput)

            {
                isSelected = true;
            }

        }

    }

    void CompareCharacters(string sc, string c)
    {
        if(sc == c)

        { }



    }

    void ChangeInputTag(string sc, string c)
    {
        if (sc == c)

        { }



    }



}
