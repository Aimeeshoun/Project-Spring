using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPoints : MonoBehaviour
{

    public GameObject[] myWeaponList2;
    public GameObject[] spawnPoints;
    public GameObject[] spawnedCharacters;
    public GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;
    public GameObject currentChar;
    public float maxTime;
    public float minTime;
    private float spawnTime;
    private float time;
    public GameObject currentWeapon;
    public float maxSpawnPerSecond;
    private float timer;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        SetRandomTime();
        time = 0;
        StartCoroutine(SpawnMonster());
        SpawnMonster();
    }

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

                        selectRandomObjects();
                        StartCoroutine(SpawnMonster()); 
                       SpawnMonster();
                        SetRandomTime();
                        time = 0;

                    }
                }


            }
        }
    }

    public IEnumerator SpawnMonster()
    {
        selectRandomObjects();
        currentChar = Instantiate(currentWeapon, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        currentChar = spawnedCharacters[1];
        currentChar.transform.parent = currentChar.transform;
        currentWeapon = spawnedCharacters[1];
        Destroy(currentChar, 80f);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
    }

    public void selectRandomObjects()

    {
 
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        index = Random.Range(0, myWeaponList2.Length);
        currentWeapon = myWeaponList2[index];

    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);

    }
}







