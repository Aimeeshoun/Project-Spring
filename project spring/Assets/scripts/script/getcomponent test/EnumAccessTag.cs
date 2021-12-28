using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumAccessTag : MonoBehaviour
{
    
    public enum WeaponType
    {shoe,
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

    [SerializeField]
    private WeaponType weaponType;
    
    [SerializeField]
    private CharacterType characterType;

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        DoStuffBasedOnType(weaponType);
    }
    
    private void DoStuffBasedOnType(WeaponType weaponType)
    {  

    }
}
