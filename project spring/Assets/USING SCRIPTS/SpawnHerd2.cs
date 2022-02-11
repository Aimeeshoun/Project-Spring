using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHerd2 : MonoBehaviour
{
    public GameObject cow;
    public int enemyNumber = 0;
    public int maxEnemies = 15;
     public int spawnWaitTime = 15;
    public GameObject[] myCharacterList;
    public GameObject[] spawnPoints;
    private GameObject currentPoint;
    private int index;
    public int spawnAmount;
    public float spawnRate;
    private bool spawning;


    public float destroytime;

 
    private float spawnTime;

    private float time = 0;
    public GameObject currentCharacter;
    private int index2;


    public float maxSpawnPerSecond;
    private float timer;

    public GameObject particle_obj;
    public ParticleSystem _the_particleSystem;


    bool isSpawning = false;
    public float minTime = 5.0f;
    public float maxTime = 15.0f;
    public GameObject[] enemies;  // Array of enemy prefabs.
    public int ints;

    public void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("cow herd spawn point");
   
       
       for (int i = 0; i < 1; i++)
        {
          
            StartCoroutine(SpawnObject());
            
        }

     
    }
    // void FixedUpdate()
    public void Update()
    {
        myCharacterList = GameObject.FindGameObjectsWithTag("Cowbox");
        time += Time.deltaTime;
        if (!isSpawning)
        {
            StartCoroutine(SpawnObject());
            SpawnObject();
           
         // InvokeRepeating("SpawnEnemy", .01f, spawnWaitTime);
            isSpawning = true; //Yep, we're going to spawn
       //   int enemyIndex = Random.Range(0, enemies.Length);
         //SpawnEnemy();
        }
    }
 // public void SpawnEnemy()
 // {
      //if (enemyNumber != maxEnemies)
      //{
         // enemyNumber++;
   //       currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
     // }
 // }

 public void selectRandomObjects()

  {

    
      index = Random.Range(0, myCharacterList.Length);
     currentCharacter = myCharacterList[index];
      index2= Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index2];

  }



    IEnumerator SpawnObject()
    {


        selectRandomObjects();
        currentCharacter = Instantiate(currentCharacter, currentPoint.transform.position, currentPoint.transform.rotation) as GameObject;
        yield return new WaitForSeconds(15);
        //We've spawned, so now we could start another spawn     
        isSpawning = false;
    }

}



