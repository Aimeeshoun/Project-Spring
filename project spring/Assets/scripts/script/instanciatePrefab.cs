using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciatePrefab : MonoBehaviour
{

    public bool needsToInstanciate;
    public GameObject target;
    public GameObject[] currentPrefab;
    public GameObject[] currentPrefab2;
    public GameObject currentPrefab_;
    public GameObject currentPrefab3_;
    public GameObject currentWeapon;
    public GameObject currentWeapon2;
    public GameObject currentPrefab2_;
    public GameObject currentPrefab4_;
    public SelectedObjects current_char;
    public SelectedObjects current_char2;
    public CharacterSpawnRandom current_weapon;
    public GameObject[] current_char_;
    public GameObject[] current_weapon_;
   

    // Start is called before the first frame update
    void Start()
    {

        
    
        current_char = GameObject.Find("character spawner sel").GetComponent<SelectedObjects>();
        
        current_char_ = current_char.myWeaponList2;
        currentWeapon = current_char.currentWeapon;

        

        current_weapon = GameObject.Find("weapon Spawner (1)").GetComponent<CharacterSpawnRandom>();
        current_weapon_ = current_weapon.myCharacterList;
        currentWeapon2 = current_weapon.currentCharacter;

    


    }

    void Update()
    {
        if (needsToInstanciate)
        {
            CreatePrefab();
        }
    }
  

    // Update is called once per frame
    public void CreatePrefab()
    {

        foreach (GameObject currentPrefab3_ in currentPrefab)
        {
            currentPrefab_ = Instantiate(currentPrefab_, target.transform.position, target.transform.rotation) as GameObject;
            currentPrefab_.tag = "Prefab";
            current_char_ = GameObject.FindGameObjectsWithTag("Prefab");
        }

        foreach (GameObject currentPrefab4_ in currentPrefab2)
        {
            currentPrefab2_ = Instantiate(currentPrefab2_, target.transform.position, target.transform.rotation) as GameObject;
            currentPrefab2_.tag = "Prefab2";
            current_weapon_ = GameObject.FindGameObjectsWithTag("Prefab2");

        }

        SelectedObject();

        

    }



}
