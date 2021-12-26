using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[CreateAssetMenu]
public class OjectsList : ScriptableObject
{


    public List<CollectionSO> WeaponSelSOList;
    public List<CollectionSO> WeaponSOList;


    private int index;
    public GameObject target1;

    public GameObject target4;


    public List<CollectionSO> CharacterSelSOList;
    public List<CollectionSO> CharacterSOList;

    private int index1;
    private int index2;
    private int index3;
    private int index4;

    private CollectionSO currentSelCharacter;




    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private GameObject currentPoint2;
    private int index5;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;
    public float maxTime = 50;
    public float minTime = 10;
    private float spawnTime;

    private float time;


    public float maxSpawnPerSecond = 2f;
    private float timer;
   
    List<GameObject> weaponSelObjects = new List<GameObject>();
    List<GameObject> weaponObjects = new List<GameObject>();
    List<GameObject> charSelObjects = new List<GameObject>();
    List<GameObject> charObjects = new List<GameObject>();

    public GameObject[] weaponSelObject2;
    public GameObject[] weaponObjects2;
    public GameObject[] charSelObjects2;
    public GameObject[] charObjects2;

    private GameObject currentWeaponsel;
    private GameObject currentWeapon;
    private GameObject currentcharsel;
    private GameObject currentchar;

    private WaitForSeconds wfs;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        SetRandomTime();
        time = 0;
        FindCharacters();
        FindCharacterSels(); 
        FindWeaponsSels();
        FindWeapons();
    }



       

    void FixedUpdate()
    {



        time += Time.deltaTime;
        if (time >= spawnTime)
        {


            if (currentWeapon.transform.childCount < spawnAmount && spawning == false)
            {

                if (maxSpawnPerSecond > 0)
                {
                    timer -= Time.deltaTime;

                    if (timer <= 0)
                    {
                        //StartCoroutine(SpawnWeapon());
                        SpawnWeapon();
                        SetRandomTime();
                        time = 0;

                        timer = 1 / maxSpawnPerSecond;
                    }
                }


            }
        }
            if (currentchar.transform.childCount < spawnAmount && spawning == false)
            {

                if (maxSpawnPerSecond > 0)
                {
                    timer -= Time.deltaTime;

                    if (timer <= 0)
                    {
                        SpawnCharacter();


                        SetRandomTime();
                        time = 0;

                        timer = 1 / maxSpawnPerSecond;
                    }
                }


            }




       
    }

    public void selectRandomWeaponSel()
    {

        index1 = Random.Range(0, weaponSelObject2.Length);
        currentWeaponsel = weaponSelObject2[index1];
      
        currentWeaponsel = Instantiate(currentWeaponsel, target1.transform.position, target1.transform.rotation) as GameObject;
        currentWeaponsel.transform.parent = currentWeaponsel.transform;
    }




    public void selectRandomWeapon()
    {

        index2 = Random.Range(0, weaponObjects2.Length);
        currentWeapon = weaponObjects2[index2];



    }

    public void selectRandomCharacter()
    {
        index3 = Random.Range(0, charSelObjects2.Length);
        currentchar = charObjects2[index3];



    }
    public void selectRandomCharacterSel()
    {
        
        index4 = Random.Range(0, charObjects2.Length);
        currentcharsel = charSelObjects2[index4];

        currentcharsel = Instantiate(currentcharsel, target4.transform.position, target4.transform.rotation) as GameObject;
        currentcharsel.transform.parent = currentcharsel.transform;


    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }



    public IEnumerator SpawnWeapon()
    {



        selectRandomWeapon();
        index2 = Random.Range(0, spawnPoints.Length);

        currentPoint = spawnPoints[index2];

        
        currentWeapon = Instantiate(currentWeapon, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        currentWeapon.transform.parent = currentWeapon.transform;

        Destroy(currentWeapon, 5);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
        
    }

    public IEnumerator SpawnCharacter()
    {

        selectRandomCharacter();
        index3 = Random.Range(0, spawnPoints.Length);
        currentPoint2 = spawnPoints[index3];

    
        currentchar = Instantiate(currentchar, currentPoint2.transform.position, currentPoint2.transform.rotation) as GameObject;
        currentchar.transform.parent = currentchar.transform;

        Destroy(currentWeapon, 5);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void FindWeaponsSels()
    {
        foreach (CollectionSO i in WeaponSelSOList)
        {

           
            weaponSelObjects.Add(i.art3D);




        }
    }

    public void FindWeapons()
    {
        foreach (CollectionSO i in WeaponSOList)
        {


            weaponObjects.Add(i.art3D);




        }
    }

    public void FindCharacterSels()
    {
        foreach (CollectionSO i in CharacterSelSOList)
        {




            charSelObjects.Add(i.art3D);




        }

    }


    public void FindCharacters()
    {
        foreach (CollectionSO i in CharacterSOList)
        {

            charObjects.Add(i.art3D);




        }

    }


    public GameObject[] gameObjects;

    void Update()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            //could test what you wanted here
            if (gameObjects[i].activeSelf)
            {
                //do something
            }
        }
    }

}
//we have our list array
//we ill go through every object in the list
//look for game object type
//put gameobject type in array
//access that array 