using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPoints : MonoBehaviour
{

    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;




    public float maxTime = 50;
    public float minTime = 10;
    private float spawnTime;

    private float time;
    private GameObject currentWeapon;
    private int index2;
  

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
 
        myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        SetRandomTime();
        time = 0;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time >= spawnTime)
        {
            if (transform.childCount < spawnAmount && spawning == false)
            {
                StartCoroutine(SpawnMonster());
                SpawnMonster();
                SetRandomTime();
                time = 0;
            }
        }
    }

    public IEnumerator SpawnMonster()
    {

        selectRandomObjects();
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        currentWeapon = Instantiate(currentWeapon, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        currentWeapon.transform.parent = gameObject.transform;

        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomObjects()

    {
        // selectRandomObjects();
        myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandom");
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];


    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
       
    }


}

