using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{

    public GameObject selectedWeaponsList;

    public List<GameObject> ActiveWeapons;

    public List<GameObject> RandomWeapons;


    public void FindObjectType(GameObject obj)
    {
        foreach (var currentObj in RandomWeapons)
        {
            if (currentObj == selectedWeaponsList)
            {
                currentObj.tag = "ActiveWeapons";
            }
        }
    }

    public void AddToList(GameObject obj)
    {
        ActiveWeapons.Add(obj);
    }

    public void RemoveFromList(GameObject obj)
    {
        foreach (var currentObj in RandomWeapons)
        {
            if (currentObj == obj)
            {
                ActiveWeapons.Remove(obj);
            }
        }
    }


}