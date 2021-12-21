using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<Object> weaponList;

    public List<FloatData> FloatDatas;

    public List<GameObject> GameObjects;


    public void FindObjectType(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            {
                void OnTriggerEnter(Collider other)
                {
                    if (other.gameObject.CompareTag("CharacterRandomObj"))
                    {
                        Destroy(other.gameObject);
                    }
                }
            }
        }
    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentObj in objectList)
        {
            if (currentObj == obj)
            {
                objectList.Remove(obj);
            }
        }
    }
}