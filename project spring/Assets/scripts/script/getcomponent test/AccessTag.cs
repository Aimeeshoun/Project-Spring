using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTag : MonoBehaviour
{

    public IDholder _otherdholder;
    public IDholder _thisidholder;
    public GameObject otherGameObject;
    public GameObject thisGameObject;

    public SelectedChar _selectedChar;
    public SelectedObjects _selectedObjects;

    public CharacterSpawnRandom _characterSpawnRandom;
    public SpawnRandomPoints _spawnRandomPoints;

    private GameObject _selWeap;
    private GameObject _spawnWeap; 
    private GameObject _spawnChar; 
    private GameObject _selChar;

    private IDholder _selWeapId;
    private IDholder _spawnWeapId;
    private IDholder _spawnCharId;
    private IDholder _selCharId;

    private GameObject _selWeapIdObj;
    private GameObject _spawnWeapIdObj;
    private GameObject _spawnCharIdObj;
    private GameObject _selCharIdObj;


    private GameObject _selWeapIdObjGO;
    private GameObject _spawnWeapIdObjGO;
    private GameObject _spawnCharIdObjGO;
    private GameObject _selCharIdObjGO;





    private string _selWeapIdObjName;
    private string _spawnWeapIdObjName;
    private string _spawnCharIdObjName;
    private string _selCharIdObjName;

    private string _thisObjName;
    private string _otherObjName;

    private string _currentselWeapname;
    private string _currentselCharname;


    void Start()
    {





    }

    private void Awake()
    {
        _thisidholder = this.gameObject.GetComponent<IDholder>();

        _selectedChar = otherGameObject.GetComponent<SelectedChar>();
        _selectedObjects = otherGameObject.GetComponent<SelectedObjects>();

        _characterSpawnRandom = otherGameObject.GetComponent<CharacterSpawnRandom>();
        _spawnRandomPoints = otherGameObject.GetComponent<SpawnRandomPoints>();

        _selWeap = _selectedObjects.currentWeapon;
        _spawnWeap = _spawnRandomPoints.currentWeapon;
        _spawnChar = _characterSpawnRandom.currentCharacter;
        _selChar = _selectedChar.currentChar;

        _selWeapId = _selWeap.GetComponent<IDholder>();
        _spawnWeapId = _spawnWeap.GetComponent<IDholder>();
        _spawnCharId = _spawnChar.GetComponent<IDholder>();
        _selCharId = _selChar.GetComponent<IDholder>();

        _selWeapIdObj = _selWeapId.GetComponent<GameObject>() as GameObject;
        _spawnWeapIdObj = _spawnWeapId.GetComponent<GameObject>() as GameObject;
        _spawnCharIdObj = _spawnCharId.GetComponent<GameObject>() as GameObject;
        _selCharIdObj = _selCharId.GetComponent<GameObject>() as GameObject;

        _selWeapIdObjName = _selWeapIdObj.name;
        _spawnWeapIdObjName  = _spawnWeapIdObj.name;
        _spawnCharIdObjName  = _spawnCharIdObj.name;
        _selCharIdObjName  = _selCharIdObj.name;

        thisGameObject = this.gameObject;
        _thisObjName = thisGameObject.name;
        

        _currentselWeapname = _selWeap.name;
        _currentselCharname= _selChar.name;


    }   
    public void OntriggerEnter(Collider other)

    {
        

        _otherdholder = other.gameObject.GetComponent<IDholder>();

        otherGameObject = other.gameObject;
        _otherObjName = otherGameObject.name;
        

        if (_currentselWeapname == _thisObjName)
        {
            if (_otherObjName == _currentselCharname)
            {
               
                   Destroy(_selWeap);
                   Destroy(_selChar);
                   Destroy(thisGameObject);
                   Destroy(otherGameObject);

            }
        }



    }
}
