using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawn : MonoBehaviour
{



    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount = 100;
    public float spawnRate = 10.0f;
    private bool spawning;


    private GameObject currentWeapon;
    private int index2;



    private float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        myWeaponList2 = GameObject.FindGameObjectsWithTag("firepit");

    }

    // Update is called once per frame
    void Update()
    {
        myWeaponList2 = GameObject.FindGameObjectsWithTag("firepit");
        if (transform.childCount < spawnAmount && spawning == false)
        {
            StartCoroutine(SpawnMonster());
            SpawnMonster();
        }

    }

    public IEnumerator SpawnMonster()
    {

        selectRandomObjects();
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        if (!currentWeapon == null) { 
            currentWeapon = Instantiate(currentWeapon, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
            currentWeapon.transform.parent = gameObject.transform;

            yield return new WaitForSeconds(spawnRate);
            spawning = false;

        }
    
    }

    public void selectRandomObjects()

    {
        // selectRandomObjects();
      
        if (myWeaponList2.Length > 0)
        {
            index = Random.Range(0, myWeaponList2.Length);
            currentWeapon = myWeaponList2[index];
        }
      


    }










}

