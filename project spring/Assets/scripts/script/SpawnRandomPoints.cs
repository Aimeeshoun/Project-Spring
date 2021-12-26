using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPoints : MonoBehaviour
{

    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    public GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;




    public float maxTime = 50;
    public float minTime = 10;
    private float spawnTime;

    private float time;
    public GameObject currentWeapon;
    private int index2;


    public float maxSpawnPerSecond = 2f;
    private float timer;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        //myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandomObj");
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

                if (maxSpawnPerSecond > 0)
                {
                    timer -= Time.deltaTime;

                    if (timer <= 0)
                    {
                        StartCoroutine(SpawnMonster());
                        SpawnMonster();
                        SetRandomTime();
                        time = 0;

                        timer = 1 / maxSpawnPerSecond;
                    }
                }


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
        Destroy(currentWeapon, 7f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;

    }

    public void selectRandomObjects()

    {
        // selectRandomObjects();
        myWeaponList2 = GameObject.FindGameObjectsWithTag("WeaponRandomObj");
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];


    }


    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }
}







