using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTag : MonoBehaviour
{

    
    public IDholder _otherdholder;
    
    public IDholder _thisidholder;
    public IDholder _selWepIdholder;
    public IDholder _selCharIdholder;

    public GameObject otherGameObject;
    public GameObject thisGameObject;

    public SelectedChar _selectedChar;
    public SelectedObjects _selectedObjects;

    public CharacterSpawnRandom _characterSpawnRandom;
    public SpawnRandomPoints _spawnRandomPoints;

    public GameObject _selWeap;
    public GameObject _spawnWeap;
    public GameObject _spawnChar;
    public GameObject _selChar;

    public IDholder _selWeapId;
    public IDholder _spawnWeapId;
    public IDholder _spawnCharId;
    public IDholder _selCharId;

    public GameObject _selWeapIdObj;
    public GameObject _spawnWeapIdObj;
    public GameObject _spawnCharIdObj;
    public GameObject _selCharIdObj;


    public GameObject _selWeapIdObjGO;
    public GameObject _spawnWeapIdObjGO;
    public GameObject _spawnCharIdObjGO;
    public GameObject _selCharIdObjGO;


    public string _selWeapIdObjName;
    public string _spawnWeapIdObjName;
    public string _spawnCharIdObjName;
    public string _selCharIdObjName;

    public string _thisObjName;
    public string _otherObjName;

    public ID thisidtag;
    public ID otheridtag;
    public ID selwepidtag;
    public ID selcharidtag;

    //   private string _currentselWeapname;
    // private string _currentselCharname;


    void Start()
    {

        

    }

    private void Update()
    {
        _thisidholder = this.gameObject.GetComponent<IDholder>();
    
        _selectedChar = _selectedChar.GetComponent<SelectedChar>();
        _selectedObjects = _selectedObjects.GetComponent<SelectedObjects>();

        _characterSpawnRandom = _characterSpawnRandom.GetComponent<CharacterSpawnRandom>();
        _spawnRandomPoints = _spawnRandomPoints.GetComponent<SpawnRandomPoints>();

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
        _spawnCharIdObj= _selCharId.GetComponent<GameObject>() as GameObject;


        _selWeap = _selectedObjects.currentWeapon;
        _spawnWeap = _spawnRandomPoints.currentWeapon;
        _spawnChar = _characterSpawnRandom.currentCharacter;
        _selChar = _selectedChar.currentChar;




        thisidtag = _thisidholder.idObj;
        selwepidtag = _thisidholder.idObj;
        selcharidtag = _selCharIdholder.idObj;

        _selWeapIdObjName = _selWepIdholder.name;
        _thisObjName = _thisidholder.name;
     
        _selCharIdObjName  = _selCharIdholder.name;

        thisGameObject = this.gameObject;



        // _currentselWeapname = _selWeap.name;
        // _currentselCharname= _selChar.name;

    }   
    public void OntriggerEnter(Collider other)

    {
       

        _otherdholder = other.gameObject.GetComponent<IDholder>();
        _otherObjName = _otherdholder.name;
        otheridtag = _otherdholder.idObj;
   
        

        if (_thisidholder == _selWeapId)
        {
            if (_otherdholder == selcharidtag)
            {
               
                   Destroy(_selWeap);
                   Destroy(_selChar);
                   Destroy(this.gameObject);
                   Destroy(other.gameObject);

            }
        }



    }
}
