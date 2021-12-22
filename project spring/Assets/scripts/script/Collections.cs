using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Collections : ScriptableObject
{

   

    public List<CollectionSO> CollectionSOList;
    public List<WeaponNUmber> WeaponNumberList;
    public List<WeaponController> WeaponControllerList;


    public InputField weaponselectTagInput;
    public InputField weaponTagInput;
    public InputField characterselectTagInput;
    public InputField characterTagInput;

    public bool isSelected;

    private GameObject weapon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
    
    }

    public void CompareWeapons(CollectionSO obj)
    {

        foreach (var CollectionSO in CollectionSOList)
        {
            if (weaponTagInput == weaponselectTagInput)

            {
               
            }

        }

    }




 }


