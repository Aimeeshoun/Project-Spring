using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareObjects : MonoBehaviour
{


    public GameObject otherGameObject;
    public SelectedObjects _selectedObjects;
    public SpawnRandomPoints _spawnRandomPoints;
    public BoxCollider _otherBoxcol;
    public CharacterSpawnRandom _characterSpawnRandom;
    public SelectedChar _selectedChar;
    public GameObject _otherGameObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Awake()
    {
        _selectedObjects = otherGameObject.GetComponent<SelectedObjects>();
        _spawnRandomPoints = otherGameObject.GetComponent<SpawnRandomPoints>();
        _characterSpawnRandom = otherGameObject.GetComponent<CharacterSpawnRandom>();
        _selectedChar = otherGameObject.GetComponent<SelectedChar>();
        _otherBoxcol = otherGameObject.GetComponent<BoxCollider>();
        //  _otherGameObj = other.gameObject.GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.name == _selectedObjects.currentWeapon.name) 
            {
                if (other.gameObject.name == _selectedChar.currentChar.name)
                {
                    if (_selectedObjects.name == _spawnRandomPoints.currentWeapon.name)
                    {
                        if (_characterSpawnRandom.name == _selectedChar.currentChar.name)
                        {

                            Destroy(_selectedObjects.currentWeapon);
                            Destroy(_selectedChar.currentChar);
                            Destroy(this.gameObject);
                            Destroy(other.gameObject);
                    }


                    }
                }
            }
    
        

    }
      
    }


