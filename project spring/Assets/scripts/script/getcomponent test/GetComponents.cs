using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{

    public GameObject otherGameObject;
    public SelectedObjects _selectedObjects;
    public SpawnRandomPoints _spawnRandomPoints;
    public BoxCollider _otherBoxcol;
    public CharacterSpawnRandom _characterSpawnRandom;
    public SelectedChar _selectedChar;
 

    // Update is called once per frame
    void Awake()
    {
        _selectedObjects = otherGameObject.GetComponent<SelectedObjects>();
        _spawnRandomPoints = otherGameObject.GetComponent<SpawnRandomPoints>();
        _characterSpawnRandom = otherGameObject.GetComponent<CharacterSpawnRandom>();
        _selectedChar = otherGameObject.GetComponent<SelectedChar>();
        _otherBoxcol = otherGameObject.GetComponent<BoxCollider>();
    }

    public void OntriggerEnter(Collider other)
    {
        if (_selectedObjects.currentWeapon == _spawnRandomPoints.currentWeapon)
        {
           if(_characterSpawnRandom.currentCharacter == _selectedChar.currentChar)
            
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }



}